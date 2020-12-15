using System;
using System.Windows.Forms;

namespace AZH_Tankai_Client.Forms
{
    public partial class RoomConnectForm : Form
    {
        public string password = null;
        public string connectCode = null;
        public RoomConnectForm()
        {
            InitializeComponent();
        }

        private void JoinRoomButton_Click(object sender, EventArgs e)
        {
            password = PasswordTextBox.Text;
            connectCode = RoomCodeTextBox.Text;
            this.Close();
        }
    }
}
