using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using signalrClient;
using Newtonsoft.Json;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

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
                    string SigBase64 = "";
                    long byteSize = 0;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        image.Save(ms, ImageFormat.Jpeg);
                        byte[] byteImage = ms.ToArray();
                        byteSize = ms.Length;
                        SigBase64 = Convert.ToBase64String(byteImage);
                    }
                    await connection.InvokeAsync("SendImage", LoginForm.name, MainLobbyForm.connectedLobby, SigBase64);

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

            connection.On<string, string>("ReceiveImage", (roomId, imgSrc) =>
            {
                this.BeginInvoke((Action)(() =>
                {
                    byte[] bytes = Convert.FromBase64String(imgSrc);
                    Image image;
                    using (MemoryStream ms = new MemoryStream(bytes))
                    {
                        image = Image.FromStream(ms);
                    }
                    PictureBox.Image = image;
                }));
            });


            connection.On<string, string>("ReceiveMessage", (roomId, chatStr) =>
            {
                this.BeginInvoke((Action)(() =>
                {
                    List<string> chatList = new List<string>();


                    string[] first = chatStr.Split('{');
                    for (int i = 0; i < first.Length; i++)
                    {
                        string[] second = first[i].Split('}');
                        for (int n = 0; n < second.Length; n++)
                        {
                            chatList.Add(second[n]);
                        }
                    }

                    ChatRichTextBox.ReadOnly = false;
                    ChatRichTextBox.Text = "";
                    for (int i = 0; i < chatList.Count; i++)
                    {

                        if (IsBase64String(chatList[i]) && chatList[i] != "" && chatList[i] != "\n")
                        {

                            byte[] bytes = Convert.FromBase64String(chatList[i]);
                            Image image;
                            using (MemoryStream ms = new MemoryStream(bytes))
                            {
                                image = Image.FromStream(ms);
                            }
                            PictureBox.Image = image;

                        }
                        else
                        {
                            ChatRichTextBox.Text += chatList[i];
                        }

                    }

                }));
            });
        }

        private static bool IsBase64String(string base64)
        {
            Span<byte> buffer = new Span<byte>(new byte[base64.Length]);
            return Convert.TryFromBase64String(base64, buffer, out int bytesParsed);
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

        private async void UndoImageButton_Click(object sender, EventArgs e)
        {
            await connection.InvokeAsync("UndoImage", LoginForm.name, MainLobbyForm.connectedLobby);
        }
    }
}
