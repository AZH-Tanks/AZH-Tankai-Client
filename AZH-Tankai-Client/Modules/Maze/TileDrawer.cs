using AZH_Tankai_Shared;
using GameView;
using System.Collections.Generic;
using System.Drawing;

namespace AZH_Tankai_Client.Modules.Maze
{
    class TileDrawer
    {
        // TODO: Redesign tiles
        private static readonly Dictionary<TileType, string> tileDictionary = new Dictionary<TileType, string>{
            { TileType.MudRoadTile, "Images/MudRoad.png" },
            { TileType.PavedRoadTile, "Images/PavedRoad.png" },
            { TileType.QuicksandTile, "Images/QuickSand.png" },
            { TileType.SandTile, "Images/Sand.png" },
            { TileType.SandstoneTile, "Images/Sandstone.png" },
            { TileType.StoneRoadTile, "Images/StoneRoad.png" }
        };

        public Point TopLeftCorner { get; set; }
        public Size TileSize { get; set; }

        private readonly Drawer drawer;

        public TileDrawer(Drawer drawer, Point topLeftCorner, Size tileSize)
        {
            this.drawer = drawer;
            TopLeftCorner = topLeftCorner;
            TileSize = tileSize;
        }

        public void DrawTile(MazeCellDTO cell, int x, int y)
        {
            drawer.DrawImage(tileDictionary[cell.TileType], $"MazeTileX{x}Y{y}", TileSize.Width, TileSize.Height, TopLeftCorner.X + x * TileSize.Width, TopLeftCorner.Y + y * TileSize.Height);
        }

        public void DrawTiles(List<List<MazeCellDTO>> tiles)
        {
            for (int i = 0; i < tiles.Count; i++)
            {
                List<MazeCellDTO> tileRow = tiles[i];
                for (int j = 0; j < tileRow.Count; j++)
                {
                    DrawTile(tileRow[j], j, i);
                }
            }
        }
    }
}
