using System;
using System.Collections.Generic;
using System.Text;

namespace AZH_Tankai_Client.Shared
{
    class Bullet
    {
        public string Type { get; set; }
        public Point Location { get; set; }
        public int Velocity { get; set; }
        public int Direction { get; set; }
        public long SpawnTime { get; set; }
    }
}
