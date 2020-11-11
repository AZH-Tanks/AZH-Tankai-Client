using AZH_Tankai_Client.Models;
using Microsoft.AspNetCore.SignalR.Client;
using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace AZH_Tankai_Client.Forms
{

    public partial class MainLobbyForm : Form
    {
        HubConnection connection;
        public static string connectedLobby = null;
        public static string mode = null;
        public MainLobbyForm()
        {
            InitializeComponent();
            connection = new HubConnectionBuilder()
               .WithUrl("https://localhost:44308/GameHub")
        //  .WithUrl("https://azh-tanks.azurewebsites.net/ControlHub")
        .Build();
            this.FormClosed += LobbyForm_FormClosed;
        }

        private async void LobbyForm_Load(object sender, EventArgs e)
        {
            await connection.StartAsync();
            NameLabel.Text = $"Welcome, {LoginForm.name}!";

            connection.On<string>("ReceiveRoomSurvival", (joinLink) =>
            {
                this.BeginInvoke((Action)(() =>
                {
                    GameLobbyForm gameLobby = new GameLobbyForm();
                    if (joinLink != null)
                    {
                        mode = "Survival";
                        connectedLobby = joinLink;
                        this.Hide();
                        gameLobby.ShowDialog();
                        this.Show();
                    }
                  
                }));
            });

            connection.On<string>("ReceiveRoomDeathmatch", (joinLink) =>
            {
                this.BeginInvoke((Action)(() =>
                {
                    GameLobbyForm gameLobby = new GameLobbyForm();
                    if (joinLink != null)
                    {
                        mode = "Deathmatch";
                        connectedLobby = joinLink;
                        this.Hide();
                        gameLobby.ShowDialog();
                        this.Show();
                    }

                }));
            });

            connection.On<string>("ReceivePublicRooms", (obj) =>
            {
                this.BeginInvoke((Action)(() =>
                {
                  
                }));
            });

        }

        private void LobbyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private async void OpenRoomButton_Click(object sender, EventArgs e)
        {
            RoomConnectForm roomConnectForm = new RoomConnectForm();
            roomConnectForm.ShowDialog();
            if (roomConnectForm.connectCode != null)
            {
                await connection.InvokeAsync("SendRoomCredentials", LoginForm.name, connection.ConnectionId, roomConnectForm.password, roomConnectForm.connectCode);
            }
        }

        private async void CreateRoomButton_Click(object sender, EventArgs e)
        {
            RoomCreateForm roomCreateForm = new RoomCreateForm();
            roomCreateForm.ShowDialog();
            Room room = roomCreateForm.room;
            if (room.SizeLimit > 0)
            {
               await connection.InvokeAsync("SendRoom", LoginForm.name, connection.ConnectionId, JsonConvert.SerializeObject(room));
            }
        }


        private void JoinSelectedRoomButton_Click(object sender, EventArgs e)
        {

        }
    }
}
