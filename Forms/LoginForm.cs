using AZH_Tankai_Client.Forms;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Windows.Forms;

namespace AZH_Tankai_Client
{
    public partial class LoginForm : Form
    {
        public static string name = "";
        private readonly string errorMsg = "Can't connect to server, try again later!";
        HubConnection connection;
        public LoginForm()
        {
            InitializeComponent();
            connection = new HubConnectionBuilder()
               .WithUrl("https://localhost:44308/PlayerHub")
        //  .WithUrl("https://azh-tanks.azurewebsites.net/ControlHub")
        .Build();
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.TextLength > 0)
            {
                try
                {
                    await connection.StartAsync();
                    await connection.InvokeAsync("SendPlayer", UsernameTextBox.Text, connection.ConnectionId);
                }
                catch
                {
                    ErrorLabel.Text = errorMsg;
                }
            }
            else
            {
                ErrorLabel.Text = "Name can't be empty!";
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

            connection.On<string>("ReceiveUser", (user) =>
            {
                this.BeginInvoke((Action)(() =>
                {
                    if (UsernameTextBox.Text == user)
                    {
                        name = user;
                        MainLobbyForm lobbyForm = new MainLobbyForm();
                        lobbyForm.Show();
                        this.Hide();
                    }
                }));
            });

            connection.On<string>("PlayerExists", (user) =>
            {
                this.BeginInvoke((Action)(() =>
                {
                    ErrorLabel.Text = $"Name {user} is currently taken!\n";
                    connection.StopAsync();
                }));
            });

        }
    }
}
