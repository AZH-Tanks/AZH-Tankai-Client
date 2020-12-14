namespace AZH_Tankai_Client.Forms
{
    partial class MainLobbyForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.RoomsListBox = new System.Windows.Forms.ListBox();
            this.RoomsLabel = new System.Windows.Forms.Label();
            this.OpenRoomButton = new System.Windows.Forms.Button();
            this.CreateRoomButton = new System.Windows.Forms.Button();
            this.JoinSelectedRoomButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NameLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(6, 15);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(97, 28);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Welcome,";
            // 
            // RoomsListBox
            // 
            this.RoomsListBox.FormattingEnabled = true;
            this.RoomsListBox.ItemHeight = 15;
            this.RoomsListBox.Location = new System.Drawing.Point(12, 83);
            this.RoomsListBox.Name = "RoomsListBox";
            this.RoomsListBox.Size = new System.Drawing.Size(334, 364);
            this.RoomsListBox.TabIndex = 2;
            // 
            // RoomsLabel
            // 
            this.RoomsLabel.AutoSize = true;
            this.RoomsLabel.Location = new System.Drawing.Point(12, 65);
            this.RoomsLabel.Name = "RoomsLabel";
            this.RoomsLabel.Size = new System.Drawing.Size(44, 15);
            this.RoomsLabel.TabIndex = 6;
            this.RoomsLabel.Text = "Rooms";
            // 
            // OpenRoomButton
            // 
            this.OpenRoomButton.Location = new System.Drawing.Point(12, 453);
            this.OpenRoomButton.Name = "OpenRoomButton";
            this.OpenRoomButton.Size = new System.Drawing.Size(110, 46);
            this.OpenRoomButton.TabIndex = 9;
            this.OpenRoomButton.Text = "Connect to room";
            this.OpenRoomButton.UseVisualStyleBackColor = true;
            this.OpenRoomButton.Click += new System.EventHandler(this.OpenRoomButton_Click);
            // 
            // CreateRoomButton
            // 
            this.CreateRoomButton.Location = new System.Drawing.Point(124, 453);
            this.CreateRoomButton.Name = "CreateRoomButton";
            this.CreateRoomButton.Size = new System.Drawing.Size(110, 46);
            this.CreateRoomButton.TabIndex = 10;
            this.CreateRoomButton.Text = "Create room";
            this.CreateRoomButton.UseVisualStyleBackColor = true;
            this.CreateRoomButton.Click += new System.EventHandler(this.CreateRoomButton_Click);
            // 
            // JoinSelectedRoomButton
            // 
            this.JoinSelectedRoomButton.Location = new System.Drawing.Point(236, 453);
            this.JoinSelectedRoomButton.Name = "JoinSelectedRoomButton";
            this.JoinSelectedRoomButton.Size = new System.Drawing.Size(110, 46);
            this.JoinSelectedRoomButton.TabIndex = 10;
            this.JoinSelectedRoomButton.Text = "Join selected room";
            this.JoinSelectedRoomButton.UseVisualStyleBackColor = true;
            this.JoinSelectedRoomButton.Click += new System.EventHandler(this.JoinSelectedRoomButton_Click);
            // 
            // MainLobbyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 511);
            this.Controls.Add(this.JoinSelectedRoomButton);
            this.Controls.Add(this.CreateRoomButton);
            this.Controls.Add(this.OpenRoomButton);
            this.Controls.Add(this.RoomsLabel);
            this.Controls.Add(this.RoomsListBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainLobbyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lobby";
            this.Load += new System.EventHandler(this.LobbyForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.ListBox RoomsListBox;
        private System.Windows.Forms.Label RoomsLabel;
        private System.Windows.Forms.Button OpenRoomButton;
        private System.Windows.Forms.Button CreateRoomButton;
        private System.Windows.Forms.Button JoinSelectedRoomButton;
    }
}