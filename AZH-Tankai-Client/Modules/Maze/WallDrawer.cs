using AZH_Tankai_Shared;
using GameView;
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
        private readonly Drawer drawer;
        public Point TopLeftCorner { get; set; }
        public Size TileSize { get; set; }

        public WallDrawer(Drawer drawer, Point topLeftCorner, Size tileSize)
        {
            this.drawer = drawer;
            TopLeftCorner = topLeftCorner;
            TileSize = tileSize;
        }

        public void DrawWall(MazeCellDTO wall, int x, int y)
        {
            if (wall.WallsState.HasFlag(TileWallsState.Top))
            {
                drawer.DrawLine(
                    $"MazeWallX{x}Y{y}Top",
                    TopLeftCorner.X + x * TileSize.Width,
                    TopLeftCorner.Y + y * TileSize.Height,
                    TopLeftCorner.X + (x + 1) * TileSize.Width,
                    TopLeftCorner.Y + y * TileSize.Height,
                    5
                );
            }
            if (wall.WallsState.HasFlag(TileWallsState.Left))
            {
                drawer.DrawLine(
                    $"MazeWallX{x}Y{y}Left",
                    TopLeftCorner.X + x * TileSize.Width,
                    TopLeftCorner.Y + y * TileSize.Height,
                    TopLeftCorner.X + x * TileSize.Width,
                    TopLeftCorner.Y + (y + 1) * TileSize.Height,
                    5
                );
            }
            if (wall.WallsState.HasFlag(TileWallsState.Bottom))
            {
                drawer.DrawLine(
                    $"MazeWallX{x}Y{y}Bottom",
                    TopLeftCorner.X + x * TileSize.Width,
                    TopLeftCorner.Y + (y + 1) * TileSize.Height,
                    TopLeftCorner.X + (x + 1) * TileSize.Width,
                    TopLeftCorner.Y + (y + 1) * TileSize.Height,
                    5
                );
            }
            if (wall.WallsState.HasFlag(TileWallsState.Right))
            {
                drawer.DrawLine(
                    $"MazeWallX{x}Y{y}Right",
                    TopLeftCorner.X + (x + 1) * TileSize.Width,
                    TopLeftCorner.Y + y * TileSize.Height,
                    TopLeftCorner.X + (x + 1) * TileSize.Width,
                    TopLeftCorner.Y + (y + 1) * TileSize.Height,
                    5
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
