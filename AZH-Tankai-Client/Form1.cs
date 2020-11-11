using AZH_Tankai_Client.Modules.Maze;
using AZH_Tankai_Client.Modules.PowerUp;
using AZH_Tankai_Shared;
using GameView;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace signalrClient
{
    // TODO: Rename Form1, Codesplitting.
    public partial class Form1 : Form
    {
        readonly IDictionary<string, Button> tanks = new Dictionary<string, Button>();
        const int speed = 15;
        string currentUser = null;
        readonly HubConnection connection;
        Window1 window;
        TestDrawer test;
        public Form1()
        {
            InitializeComponent();
            // TestDrawer testDrawer = new TestDrawer(this);

            this.KeyDown += Form1_KeyDown;
            this.KeyPreview = true;

            connection = new HubConnectionBuilder()
              //.WithUrl("https://azh-tanks.azurewebsites.net/ControlHub")
              .WithUrl("https://localhost:44308/ControlHub")
              .Build();

            connection.Closed += async (error) =>
            {
                await Task.Delay(new Random().Next(0, 5) * 1000);
                await connection.StartAsync();
                OutputBox.Text += error.Message + "\n";
            };

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            OutputBox.Text += "Starting connection..\n";
            await connection.StartAsync();
            OutputBox.Text += "Connection started!\n";

            connection.On<string>("ReceiveUser", (user) =>
            {
                this.BeginInvoke((Action)(() =>
                {
                    CreatePlayer(user);
                }));

            });


            connection.On<string, int, int>("ReceiveCoordinate", (user, x, y) =>
            {
                this.BeginInvoke((Action)(() =>
                {
                    if (!tanks.ContainsKey(user))
                    {
                        CreatePlayer(user);
                    }
                    tanks[user].Location = new Point(x, y);
                }));
            });

            connection.On<string>("PlayerExists", (user) =>
            {
                this.BeginInvoke((Action)(() =>
                {
                    OutputBox.Text += $"Name {user} is currently taken!\n";
                }));
            });

            connection.On<string>("TerminatePlayer", (user) =>
            {
                this.BeginInvoke((Action)(() =>
                {
                    OutputBox.Text += $"{user} disconnected!\n";
                    Button tank = tanks[user];
                    this.Controls.Remove(tank);
                    tanks.Remove(user);

                }));
            });

            connection.On<string>("ReceiveMaze", (maze) =>
            {
                Graphics graphics = this.CreateGraphics();
                TileDrawer tileDrawer = new TileDrawer(window.Drawer, new Point(5, 5), new Size(30, 30));
                WallDrawer wallDrawer = new WallDrawer(window.Drawer, new Point(5, 5), new Size(30, 30));
                List<List<MazeCellDTO>> cells = JsonSerializer.Deserialize<List<List<MazeCellDTO>>>(maze);
                tileDrawer.DrawTiles(cells);
                wallDrawer.DrawWalls(cells);
            });

            connection.On<string>("ReceivePowerUp", (powerUp) =>
            {
                Graphics graphics = this.CreateGraphics();
                PowerUpDrawer powerUpDrawer = new PowerUpDrawer(window.Drawer, new Point(5, 5), new Size(30, 30), new Size(20, 20));
                powerUpDrawer.DrawPowerUp(JsonSerializer.Deserialize<PowerUpDTO>(powerUp));
            });

            connection.On<string>("PowerUpStrategy", (strategy) =>
            {
                OutputBox.Text += $"PowerUp strategy is {strategy}\n";
            });

        }

        private async void CreatePlayerButton_Click(object sender, EventArgs e)
        {
            currentUser = username.Text;
            await connection.InvokeAsync("SendPlayer", username.Text, connection.ConnectionId);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (currentUser != null)
            {
                Button tank = tanks[currentUser];
                int x = tank.Location.X;
                int y = tank.Location.Y;

                if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
                {
                    x += speed;
                }
                else if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
                {
                    x -= speed;
                }
                else if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
                {
                    y -= speed;
                }
                else if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
                {
                    y += speed;
                }

                if (tank.Location.X != x || tank.Location.Y != y)
                {
                    tank.Location = new Point(x, y);
                    OutputBox.Text += $"X:{x}, Y:{y}\n";
                    connection.InvokeAsync("SendCoordinate", username.Text, x, y);

                }
            }
        }


        private void CreatePlayer(string user)
        {
            Button tank = new Button();
            OutputBox.Text += $"{user} joined!\n";
            tank.BackColor = Color.FromArgb(new Random().Next(1, 255), new Random().Next(1, 255), new Random().Next(1, 255));
            tank.Text = user;
            tank.Width = 30;
            tank.Height = 30;
            tank.Location = new Point(500, 200);
            tank.Enabled = false;
            this.Controls.Add(tank);
            tanks.Add(user, tank);
        }

        private async void GenerateMaze_Click(object sender, EventArgs e)
        {
            this.Invalidate();
            await connection.InvokeAsync("CreateMaze");
            await connection.InvokeAsync("StopPowerUpGeneration");
            await connection.InvokeAsync("GeneratePowerUps");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            window = new Window1();
            ElementHost.EnableModelessKeyboardInterop(window);
            window.Show();
            test = new TestDrawer(window.Drawer, this);
        }
    }

}
