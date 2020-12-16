using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GameView
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Drawer Drawer { get; private set; }
        public Window1()
        {
            InitializeComponent();
            Canvas canvas = new Canvas();
            this.Content = canvas;
            Drawer = new Drawer(canvas);
        }

        public void AddKeyDownHandler(Action<object, KeyEventArgs> handler)
        {
            this.KeyDown += new KeyEventHandler(handler);
        }
    }
}
