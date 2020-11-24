using GameView;
using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace AZH_Tankai_Client.Modules.Maze
{
    class TestDrawer
    {
        private Drawer drawer;
        private Form invoker;
        private Random rng;
        private bool initialized;
        public TestDrawer(Drawer drawer, Form invoker)
        {
            System.Timers.Timer timer = new System.Timers.Timer(1000);
            this.invoker = invoker;
            timer.Elapsed += onTick;
            this.drawer = drawer;
            rng = new Random();
            timer.Enabled = true;
        }

        private void onTick(Object source, ElapsedEventArgs e)
        {
            invoker.Invoke((Action)delegate
            {
                if (!initialized)
                {
                    drawer.DrawRectangle("testRect", rng.Next(300), rng.Next(300), 5, 5, 10);
                    initialized = true;
                }
                else
                {
                    drawer.MoveObject("testRect", rng.Next(300), rng.Next(300), 1000);
                }
            });
        }


    }
}
