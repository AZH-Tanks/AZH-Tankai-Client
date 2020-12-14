using AZH_Tankai_Client.Models;
using System;
using System.Windows.Forms;

namespace AZH_Tankai_Client.Forms
{
    public partial class RoomCreateForm : Form
    {
        public Room room = new Room();
        public RoomCreateForm()
        {
            InitializeComponent();
        }

        private void PrivateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (PrivateRadioButton.Checked)
            {
                RoomCodeLabel.Visible = true;
                PasswordTextBox.Visible = true;
            }
            else
            {
                RoomCodeLabel.Visible = false;
                PasswordTextBox.Visible = false;
            }
        }

        private void DeathMatchRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (DeathMatchRadioButton.Checked)
            {
                DurationLabel.Visible = true;
                DurationUpDown.Visible = true;
            }
            else
            {
                DurationLabel.Visible = false;
                DurationUpDown.Visible = false;
            }
        }

        private void CreateRoomButton_Click(object sender, EventArgs e)
        {
            room.IsPublic = !PublicRadioButton.Checked ? false : true;
            room.Password = PasswordTextBox.Text;
            room.SizeLimit = (short)RoomSizeUpDown.Value;
            room.Duration = (short)DurationUpDown.Value;
            room.IsSurvival = !SurvivalRadioButton.Checked ? false : true;
         
            this.Close();
        }
    }
}
