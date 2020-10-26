using AZH_Tankai_Shared;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace AZH_Tankai_Client.Modules.Maze
{
    public static class Extensions
    {
        public static bool HasFlag(this TileWallsState tileWallsState, TileWallsState flag)
        {
            return ((int)tileWallsState & (int)flag) != 0;
        }
    }
    class WallDrawer
    {
        private readonly Graphics graphics;
        private readonly Pen pen;
        public Point TopLeftCorner { get; set; }
        public Size TileSize { get; set; }

        public WallDrawer(Graphics graphics, Point topLeftCorner, Size tileSize)
        {
            this.graphics = graphics;
            TopLeftCorner = topLeftCorner;
            TileSize = tileSize;
            pen = new Pen(Color.FromArgb(255, 0, 0, 0), 5)
            {
                Alignment = PenAlignment.Center
            };
        }

        public void DrawWall(MazeCellDTO wall, int x, int y)
        {
            if (wall.WallsState.HasFlag(TileWallsState.Top))
            {
                graphics.DrawLine(
                    pen,
                    new Point(TopLeftCorner.X + x * TileSize.Width, TopLeftCorner.Y + y * TileSize.Height),
                    new Point(TopLeftCorner.X + (x + 1) * TileSize.Width, TopLeftCorner.Y + y * TileSize.Height)
                );
            }
            if (wall.WallsState.HasFlag(TileWallsState.Left))
            {
                graphics.DrawLine(
                    pen,
                    new Point(TopLeftCorner.X + x * TileSize.Width, TopLeftCorner.Y + y * TileSize.Height),
                    new Point(TopLeftCorner.X + x * TileSize.Width, TopLeftCorner.Y + (y + 1) * TileSize.Height)
                );
            }
            if (wall.WallsState.HasFlag(TileWallsState.Bottom))
            {
                graphics.DrawLine(
                    pen,
                    new Point(TopLeftCorner.X + x * TileSize.Width, TopLeftCorner.Y + (y + 1) * TileSize.Height),
                    new Point(TopLeftCorner.X + (x + 1) * TileSize.Width, TopLeftCorner.Y + (y + 1) * TileSize.Height)
                );
            }
            if (wall.WallsState.HasFlag(TileWallsState.Right))
            {
                graphics.DrawLine(
                    pen,
                    new Point(TopLeftCorner.X + (x + 1) * TileSize.Width, TopLeftCorner.Y + y * TileSize.Height),
                    new Point(TopLeftCorner.X + (x + 1) * TileSize.Width, TopLeftCorner.Y + (y + 1) * TileSize.Height)
                );
            }
        }

        public void DrawWalls(List<List<MazeCellDTO>> walls)
        {
            for (int i = 0; i < walls.Count; i++)
            {
                List<MazeCellDTO> wallRow = walls[i];
                for (int j = 0; j < wallRow.Count; j++)
                {
                    DrawWall(wallRow[j], j, i);
                }
            }
        }
    }
}
