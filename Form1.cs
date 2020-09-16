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

namespace signalrClient
{
    public partial class Form1 : Form
    {
        const int speed = 5;
        string currentUser = null;
        HubConnection connection;
        public Form1()
        {
            InitializeComponent();

            this.KeyDown += Form1_KeyDown;
            this.KeyPreview = true;

            connection = new HubConnectionBuilder()
              .WithUrl("https://localhost:44308/ControlHub")
              .Build();

            connection.Closed += async (error) =>
            {
                await Task.Delay(new Random().Next(0, 5) * 1000);
                await connection.StartAsync();
                OutputBox.Text += error.Message + "\n";
            };

        }

        Button tank = new Button();

        private async void Form1_Load(object sender, EventArgs e)
        {
            OutputBox.Text += "Starting connection..\n";
            await connection.StartAsync();
            OutputBox.Text += "Connection started!\n";

            connection.On<string, int, int>("ReceiveCoordinate", (user, x, y) =>
            {
                this.BeginInvoke((Action)(() =>
                {
                    tank.Location = new Point(x, y);
                }));
            });

            connection.On<string>("ReceiveUser", (user) =>
            {
                this.BeginInvoke((Action)(() =>
                {
                    currentUser = user;
                    OutputBox.Text += $"{user} joined!\n";
                    tank.BackColor = Color.FromArgb(new Random().Next(1, 255), new Random().Next(1, 255), new Random().Next(1, 255));
                    tank.Width = 30;
                    tank.Height = 30;
                    tank.Location = new Point(500, 200);
                    tank.Enabled = false;
                    this.Controls.Add(tank);
                }));
            });
        }

        private async void CreatePlayerButton_Click(object sender, EventArgs e)
        {
            await connection.InvokeAsync("SendPlayer", username.Text);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (currentUser != null)
            {
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


    }

}
