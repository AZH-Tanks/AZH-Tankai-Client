using Microsoft.AspNetCore.SignalR.Client;
using signalrClient;
using System;
using System.Collections.Generic;
using System.Text;
using AZH_Tankai_Client.Shared;
using Size = System.Drawing.Size;
using Graphics = System.Drawing.Graphics;
using Color = System.Drawing.Color;
using Pen = System.Drawing.Pen;
using SolidBrush = System.Drawing.SolidBrush;
using Rectangle = System.Drawing.Rectangle;
using PointF = System.Drawing.PointF;
using AZH_Tankai_Client.Modules;
using AZH_Tankai_Client.Modules.Maze;
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
                Graphics graphics = form.CreateGraphics();
                TileDrawer tileDrawer = new TileDrawer(graphics, new System.Drawing.Point(450, 30), new Size(50, 50));
                WallDrawer wallDrawer = new WallDrawer(graphics, new System.Drawing.Point(450, 30), new Size(50, 50));
                List<List<MazeCellDTO>> cells = JsonSerializer.Deserialize<List<List<MazeCellDTO>>>(maze);
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
                }));
            });
        }

        public void ReceiveBulletCoordinates()
        {
            connection.On<string>("ReceiveBulletCoordinates", (bulletList) =>
            {
                form.BeginInvoke((Action)(() =>
                {
                    List<Bullet> list = JsonSerializer.Deserialize<List<Bullet>>(bulletList);
                    form.UpdateBullets(list);
                }));
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
