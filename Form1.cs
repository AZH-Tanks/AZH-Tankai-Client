using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using Microsoft.AspNetCore.SignalR.Client;
using System.Drawing.Drawing2D;

namespace signalrClient
{
    public partial class Form1 : Form
    {
        readonly IDictionary<string, Button> tanks = new Dictionary<string, Button>();
        readonly List<Point> bullets = new List<Point>();
        const int speed = 15;
        string currentUser = null;
        HubConnection connection;
        public Form1()
        {
            InitializeComponent();

            this.KeyDown += Form1_KeyDown;
            this.KeyPreview = true;

            connection = new HubConnectionBuilder()
              //.WithUrl("https://azh-tanks.azurewebsites.net/ControlHub")
              .WithUrl("http://localhost:5000/ControlHub")
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

            connection.On<string, int, int>("ReceiveBulletCoordinate", (user, x, y) =>
            {
                this.BeginInvoke((Action)(() =>
                {
                    CreateBullet(user, x, y);
                    bullets.Add(new Point(x, y));
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
<<<<<<< Updated upstream
=======
                HandleFiring(sender, e);
>>>>>>> Stashed changes
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
                tank.Location = new Point(x, y);
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
                connection.InvokeAsync("SendFireBullet", username.Text, x, y);
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

        private void CreateBullet(string user, int x, int y)
        {
            Button bullet = new Button();
            OutputBox.Text += $"{user} Fired a bullet\n";
            bullet.BackColor = Color.Black;
            bullet.Text = user;
            bullet.Width = 10;
            bullet.Height = 10;
            bullet.Location = new Point(x, y);
            bullet.Enabled = false;
            //  System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            //     CreateGraphics().FillRectangle(myBrush, new Rectangle(x, y, 10, 10));
            //      this.Controls.Add(bullet);
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            SolidBrush myBrush = new SolidBrush(System.Drawing.Color.Black);
            bullets.ForEach((bullet) =>
            {
                e.Graphics.FillEllipse(myBrush, new Rectangle(bullet.X, bullet.Y, 8, 8));
                
            });
            myBrush.Dispose();
        }
    }
}