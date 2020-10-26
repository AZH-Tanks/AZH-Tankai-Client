using AZH_Tankai_Shared;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AZH_Tankai_Client.Modules.Maze
{
    class TileDrawer
    {
        // TODO: Redesign tiles
        private static readonly Dictionary<TileType, string> tileDictionary = new Dictionary<TileType, string>(){
            { TileType.MudRoadTile, "Images/MudRoad.png" },
            { TileType.PavedRoadTile, "Images/PavedRoad.png" },
            { TileType.QuicksandTile, "Images/QuickSand.png" },
            { TileType.SandTile, "Images/Sand.png" },
            { TileType.SandstoneTile, "Images/Sandstone.png" },
            { TileType.StoneRoadTile, "Images/StoneRoad.png" }
        };

        public Point TopLeftCorner { get; set; }
        public Size TileSize { get; set; }

        private Graphics graphics { get; set; }

        public TileDrawer(Graphics graphics, Point topLeftCorner, Size tileSize)
        {
            this.graphics = graphics;
            TopLeftCorner = topLeftCorner;
            TileSize = tileSize;
        }

        public void DrawTile(MazeCellDTO cell, int x, int y)
        {
            Image image = Image.FromFile(tileDictionary[cell.TileType]);
            graphics.DrawImage(image, TopLeftCorner.X + x * TileSize.Width, TopLeftCorner.Y + y * TileSize.Height, TileSize.Width, TileSize.Height);
        }

        public void DrawTiles(List<List<MazeCellDTO>> tiles)
        {
            List<PictureBox> tileGrid = new List<PictureBox>();
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
