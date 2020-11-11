using AZH_Tankai_Shared;
using GameView;
using System.Collections.Generic;
using System.Drawing;

namespace AZH_Tankai_Client.Modules.PowerUp
{
    class PowerUpDrawer
    {
        // TODO: Redesign powerups
        private static readonly Dictionary<PowerUpType, string> powerUpDictionary = new Dictionary<PowerUpType, string>{
            { PowerUpType.Camo, "C" },
            { PowerUpType.ExplodingBullet, "E" },
            { PowerUpType.HomingMissile, "H" },
            { PowerUpType.Laser, "L" },
            { PowerUpType.Machinegun, "M" },
            { PowerUpType.RemoveWall, "R" },
            { PowerUpType.SpeedUpgrade, "S" }
        };

        public Point TopLeftCorner { get; set; }
        public Size TileSize { get; set; }
        public Size PowerUpSize { get; set; }

        private readonly Drawer drawer;

        public PowerUpDrawer(Drawer drawer, Point topLeftCorner, Size tileSize, Size powerUpSize)
        {
            this.drawer = drawer;
            TopLeftCorner = topLeftCorner;
            TileSize = tileSize;
            PowerUpSize = powerUpSize;
        }

        public void DrawPowerUp(PowerUpDTO powerUp)
        {
            drawer.DrawText(
                $"PowerUpX{powerUp.Location.X}Y{powerUp.Location.Y}",
                powerUpDictionary[powerUp.Type],
                TopLeftCorner.X + powerUp.Location.X * TileSize.Width + (TileSize.Width - PowerUpSize.Width) / 2,
                TopLeftCorner.Y + powerUp.Location.Y * TileSize.Height + (TileSize.Height - PowerUpSize.Height) / 2,
                PowerUpSize.Width,
                PowerUpSize.Height,
                5
            );
        }
    }
}
