namespace AZH_Tankai_Client.Forms
{
    partial class RoomConnectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GameRoomCodeLabel = new System.Windows.Forms.Label();
            this.RoomCodeTextBox = new System.Windows.Forms.TextBox();
            this.JoinRoomButton = new System.Windows.Forms.Button();
            this.RoomCodeLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GameRoomCodeLabel
            // 
            this.GameRoomCodeLabel.AutoSize = true;
            this.GameRoomCodeLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GameRoomCodeLabel.Location = new System.Drawing.Point(50, 22);
            this.GameRoomCodeLabel.Name = "GameRoomCodeLabel";
            this.GameRoomCodeLabel.Size = new System.Drawing.Size(164, 28);
            this.GameRoomCodeLabel.TabIndex = 0;
            this.GameRoomCodeLabel.Text = "Game room code";
            // 
            // RoomCodeTextBox
            // 
            this.RoomCodeTextBox.Location = new System.Drawing.Point(50, 79);
            this.RoomCodeTextBox.Name = "RoomCodeTextBox";
            this.RoomCodeTextBox.Size = new System.Drawing.Size(164, 23);
            this.RoomCodeTextBox.TabIndex = 2;
            // 
            // JoinRoomButton
            // 
            this.JoinRoomButton.Location = new System.Drawing.Point(50, 156);
            this.JoinRoomButton.Name = "JoinRoomButton";
            this.JoinRoomButton.Size = new System.Drawing.Size(164, 23);
            this.JoinRoomButton.TabIndex = 1;
            this.JoinRoomButton.Text = "Join";
            this.JoinRoomButton.UseVisualStyleBackColor = true;
            this.JoinRoomButton.Click += new System.EventHandler(this.JoinRoomButton_Click);
            // 
            // RoomCodeLabel
            // 
            this.RoomCodeLabel.AutoSize = true;
            this.RoomCodeLabel.Location = new System.Drawing.Point(50, 61);
            this.RoomCodeLabel.Name = "RoomCodeLabel";
            this.RoomCodeLabel.Size = new System.Drawing.Size(68, 15);
            this.RoomCodeLabel.TabIndex = 3;
            this.RoomCodeLabel.Text = "Room code";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(50, 109);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(112, 15);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password (optional)";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(50, 127);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(164, 23);
            this.PasswordTextBox.TabIndex = 2;
            // 
            // RoomConnectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 202);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.RoomCodeLabel);
            this.Controls.Add(this.JoinRoomButton);
            this.Controls.Add(this.RoomCodeTextBox);
            this.Controls.Add(this.GameRoomCodeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RoomConnectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Connect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GameRoomCodeLabel;
        private System.Windows.Forms.TextBox RoomCodeTextBox;
        private System.Windows.Forms.Button JoinRoomButton;
        private System.Windows.Forms.Label RoomCodeLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
    }
}