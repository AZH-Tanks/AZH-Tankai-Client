using AZH_Tankai_Shared;
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

        private readonly Graphics graphics;

        public PowerUpDrawer(Graphics graphics, Point topLeftCorner, Size tileSize, Size powerUpSize)
        {
            this.graphics = graphics;
            TopLeftCorner = topLeftCorner;
            TileSize = tileSize;
            PowerUpSize = powerUpSize;
        }

        public void DrawPowerUp(PowerUpDTO powerUp)
        {
            var rectangle = new Rectangle(TopLeftCorner.X + powerUp.Location.X * TileSize.Width + 10, TopLeftCorner.Y + powerUp.Location.Y * TileSize.Height + 10, PowerUpSize.Width, PowerUpSize.Height);
            
            var stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            graphics.FillRectangle(
                new System.Drawing.SolidBrush(System.Drawing.Color.White),
                rectangle
            );
            graphics.DrawString(powerUpDictionary[powerUp.Type], new Font("Arial", 14), Brushes.Black, rectangle, stringFormat);
        }
    }
}
