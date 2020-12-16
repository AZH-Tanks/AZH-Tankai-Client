using Microsoft.AspNetCore.SignalR.Client;
using signalrClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using AZH_Tankai_Client.Modules.Maze;
using AZH_Tankai_Client.Modules.Bullet;
using AZH_Tankai_Client.Modules.PowerUp;
using System.Text.Json;
using AZH_Tankai_Shared;

namespace AZH_Tankai_Client.Modules
{
    class ConnectionAdapter : IConnection
    {
        private readonly Form1 form;
        private readonly HubConnection connection;

        public ConnectionAdapter(Form1 form, HubConnection connection)
        {
            this.form = form;
            this.connection = connection;
        }

        public void ReceiveMaze()
        {
            connection.On<string>("ReceiveMaze", (maze) =>
            {
                TileDrawer tileDrawer = new TileDrawer(form.Window.Drawer, new Point(5, 5), new Size(40, 40));
                WallDrawer wallDrawer = new WallDrawer(form.Window.Drawer, new Point(5, 5), new Size(40, 40));
                List<List<MazeCellDTO>> cells = JsonSerializer.Deserialize<List<List<MazeCellDTO>>>(maze);
                form.Window.Width = cells[0].Count * 40 + 50;
                form.Window.Height = cells.Count * 40 + 50;
                tileDrawer.DrawTiles(cells);
                wallDrawer.DrawWalls(cells);
            });
        }

        public void ReceivePlayer()
        {
            connection.On<string>("ReceiveUser", (user) =>
            {
                form.BeginInvoke((Action)(() =>
                {
                    form.CreatePlayer(user);
                    form.Window.Drawer.DrawRectangle(user, 20, 20, 10, 10, 30);
                }));
            });
        }

        public void ReceiveCoordinate()
        {

            connection.On<string, int, int>("ReceiveCoordinate", (user, x, y) =>
            {
                form.BeginInvoke((Action)(() =>
                {
                    form.CreateTank(user, x, y);
                    form.Window.Drawer.MoveObject(user, x, y, 50);
                }));
            });
        }

        public void ReceiveBulletCoordinates()
        {
            BulletDrawer bulletDrawer = new BulletDrawer(form.Window.Drawer);
            connection.On<string>("ReceiveBulletCoordinates", (bulletList) =>
            {
                List<BulletDTO> list = JsonSerializer.Deserialize<List<BulletDTO>>(bulletList);
                bulletDrawer.DrawBullets(list);
            });
        }

        public void ReceivePowerUp()
        {
            connection.On<string>("ReceivePowerUp", (powerUp) =>
            {
                PowerUpDrawer powerUpDrawer = new PowerUpDrawer(form.Window.Drawer, new System.Drawing.Point(5, 5), new Size(40, 40), new Size(25, 25));
                powerUpDrawer.DrawPowerUp(JsonSerializer.Deserialize<PowerUpDTO>(powerUp));
            });
        }


        public void PlayerExists()
        {
            connection.On<string>("PlayerExists", (user) =>
            {
                form.BeginInvoke((Action)(() =>
                {
                    form.PrintText($"Name {user} is currently taken!\n");
                }));
            });
        }

        public void TerminatePlayer()
        {
            connection.On<string>("TerminatePlayer", (user) =>
            {
                form.BeginInvoke((Action)(() =>
                {
                    form.RemoveTank(user);
                }));
            });
        }
    }
}
