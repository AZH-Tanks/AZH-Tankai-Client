using AZH_Tankai_Client.Modules.Maze;
using GameView;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using AZH_Tankai_Client.Modules;
using System.Windows.Forms.Integration;

namespace signalrClient
{
    // TODO: Rename Form1, Codesplitting.
    public partial class Form1 : Form
    {
        readonly IDictionary<string, Button> tanks = new Dictionary<string, Button>();
        private ConnectionAdapter connectionAdapter;
        const int speed = 15;
        string currentUser = null;
        readonly HubConnection connection;
        public Window1 Window { get; private set; }
        public Form1()
        {
            InitializeComponent();
            // TestDrawer testDrawer = new TestDrawer(this);

            this.KeyPreview = true;

            connection = new HubConnectionBuilder()
              //.WithUrl("https://azh-tanks.azurewebsites.net/ControlHub")
              .WithUrl("https://localhost:44308/ControlHub")
              .Build();

            connectionAdapter = new ConnectionAdapter(this, connection);

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

            Window = new Window1();
            ElementHost.EnableModelessKeyboardInterop(Window);
            Window.Show();

            connectionAdapter.ReceivePlayer();
            connectionAdapter.ReceiveCoordinate();
            connectionAdapter.ReceiveBulletCoordinates();
            connectionAdapter.PlayerExists();
            connectionAdapter.TerminatePlayer();
            connectionAdapter.ReceiveMaze();

            await connection.InvokeAsync("CreateMaze");
        }

        // TODO: fix tanks.
        public void RemoveTank(string user)
        {
            OutputBox.Text += $"{user} disconnected!\n";
            Button tank = tanks[user];
            this.Controls.Remove(tank);
            tanks.Remove(user);
        }

        public void PrintText(string text)
        {
            OutputBox.Text += text;
        }

        public void CreateTank(string user, int x, int y)
        {
            if (!tanks.ContainsKey(user))
            {
                CreatePlayer(user);
            }
            tanks[user].Location = new System.Drawing.Point(x, y);
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
                HandleMovement(sender, e);
                HandleFiring(sender, e);
            }
        }

        private void HandleMovement(object sender, KeyEventArgs e)
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
                tank.Location = new System.Drawing.Point(x, y);
                OutputBox.Text += $"X:{x}, Y:{y}\n";
                connection.InvokeAsync("SendCoordinate", username.Text, x, y);
            }
        }

        private void HandleFiring(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.F)
            {
                Button tank = tanks[currentUser];
                int x = tank.Location.X;
                int y = tank.Location.Y;

                var random = new Random();
                var list = new List<string> { "Basic", "Laser", "Shrapnel" };
                int index = random.Next(list.Count);

                connection.InvokeAsync("SendFireBullet", username.Text, list[index], x, y);
            }
        }

        public void CreatePlayer(string user)
        {
            Button tank = new Button();
            OutputBox.Text += $"{user} joined!\n";
            tank.BackColor = Color.FromArgb(new Random().Next(1, 255), new Random().Next(1, 255), new Random().Next(1, 255));
            tank.Text = user;
            tank.Width = 30;
            tank.Height = 30;
            tank.Location = new System.Drawing.Point(500, 200);
            tank.Enabled = false;
            this.Controls.Add(tank);
            tanks.Add(user, tank);
        }

        private async void GenerateMaze_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }

}
