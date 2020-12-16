using System;
using System.Collections.Generic;
using System.Text;
using GameView;
using AZH_Tankai_Shared;

namespace AZH_Tankai_Client.Modules.Bullet
{
    public class BulletDrawer
    {
        private readonly Drawer drawer;
        private Dictionary<string, BulletDTO> bullets;

        public BulletDrawer(Drawer drawer)
        {
            this.drawer = drawer;
            bullets = new Dictionary<string, BulletDTO>();
        }

        public void DrawBullets(List<BulletDTO> bullets)
        {
            List<string> drawnBullets = new List<string>();
            foreach (BulletDTO bullet in bullets)
            {
                drawnBullets.Add(bullet.Id);
                if (this.bullets.ContainsKey(bullet.Id))
                {
                    drawer.MoveObject(bullet.Id, bullet.X, bullet.Y, 100);
                }
                else
                {
                    this.bullets[bullet.Id] = bullet;
                    switch (bullet.Type)
                    {
                        // TODO: fix moving lines
                        //case "Laser":
                        //    drawer.DrawLine(
                        //        bullet.Id,
                        //        bullet.X,
                        //        bullet.Y,
                        //        bullet.X + 30,
                        //        bullet.Y,
                        //        3
                        //    );
                        //    break;
                        case "Shrapnel":
                            drawer.DrawRectangle(
                                bullet.Id,
                                bullet.X,
                                bullet.Y,
                                3,
                                3,
                                15
                            );
                            break;
                        default:
                            drawer.DrawEllipse(
                                bullet.Id,
                                bullet.X,
                                bullet.Y,
                                8,
                                8,
                                15
                            );
                            break;
                    }
                }
                foreach (string bulletId in this.bullets.Keys)
                {
                    if (!drawnBullets.Contains(bulletId))
                    {
                        drawer.RemoveObject(bulletId);
                    }
                }
            }
        }
    }
}
