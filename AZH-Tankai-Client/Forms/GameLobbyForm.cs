using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using signalrClient;

namespace AZH_Tankai_Client.Forms
{
    public partial class GameLobbyForm : Form
    {
        HubConnection connection;
        public GameLobbyForm()
        {
            InitializeComponent();
            connection = new HubConnectionBuilder()
               .WithUrl("https://localhost:44308/ControlHub")
        //  .WithUrl("https://azh-tanks.azurewebsites.net/ControlHub")
        .Build();
        }


        private async void SendImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog.Filter = ".png files (*.png)|*.png|.jpg files (*.jpg)|*.jpg|.jpeg files (*.jpeg)|*.jpeg";
            DialogResult result = OpenFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    Bitmap image = new Bitmap(OpenFileDialog.FileName);
                    //    await connection.InvokeAsync("SendImage", NameLabel.Text, connection.ConnectionId, JsonConvert.SerializeObject(image));

                }
                catch (IOException)
                {
                }
            }
        }

        private async void GameLobbyForm_Load(object sender, EventArgs e)
        {
            ModeLabel.Text = MainLobbyForm.mode;
            JoinCodeLabel.Text = MainLobbyForm.connectedLobby;

            await connection.StartAsync();
            var aa = connection.ConnectionId;
            connection.On<string, string>("ReceiveMessage", (roomId, chatStr) =>
            {
                this.BeginInvoke((Action)(() =>
                {
                    ChatRichTextBox.Text = chatStr;
                }));
            });
        }

        private async void SendTextButton_Click(object sender, EventArgs e)
        {
            await connection.InvokeAsync("SendTextMessage", LoginForm.name, MainLobbyForm.connectedLobby, TextTextBox.Text);
        }

        private async void UndoButton_Click(object sender, EventArgs e)
        {
            await connection.InvokeAsync("UndoTextMessage", LoginForm.name, MainLobbyForm.connectedLobby);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
