namespace AZH_Tankai_Client.Forms
{
    partial class RoomCreateForm
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
            this.CreateRoomLabel = new System.Windows.Forms.Label();
            this.CreateRoomButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.RoomCodeLabel = new System.Windows.Forms.Label();
            this.PublicRadioButton = new System.Windows.Forms.RadioButton();
            this.PrivateRadioButton = new System.Windows.Forms.RadioButton();
            this.RoomModeGroupBox = new System.Windows.Forms.GroupBox();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.SurvivalRadioButton = new System.Windows.Forms.RadioButton();
            this.DeathMatchRadioButton = new System.Windows.Forms.RadioButton();
            this.GameModeTextBox = new System.Windows.Forms.GroupBox();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.DurationUpDown = new System.Windows.Forms.NumericUpDown();
            this.RoomSizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.RoomModeGroupBox.SuspendLayout();
            this.GameModeTextBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DurationUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomSizeUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateRoomLabel
            // 
            this.CreateRoomLabel.AutoSize = true;
            this.CreateRoomLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateRoomLabel.Location = new System.Drawing.Point(90, 13);
            this.CreateRoomLabel.Name = "CreateRoomLabel";
            this.CreateRoomLabel.Size = new System.Drawing.Size(121, 28);
            this.CreateRoomLabel.TabIndex = 0;
            this.CreateRoomLabel.Text = "Create room";
            // 
            // CreateRoomButton
            // 
            this.CreateRoomButton.Location = new System.Drawing.Point(52, 336);
            this.CreateRoomButton.Name = "CreateRoomButton";
            this.CreateRoomButton.Size = new System.Drawing.Size(200, 23);
            this.CreateRoomButton.TabIndex = 1;
            this.CreateRoomButton.Text = "Create";
            this.CreateRoomButton.UseVisualStyleBackColor = true;
            this.CreateRoomButton.Click += new System.EventHandler(this.CreateRoomButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(6, 89);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(188, 23);
            this.PasswordTextBox.TabIndex = 2;
            this.PasswordTextBox.Visible = false;
            // 
            // RoomCodeLabel
            // 
            this.RoomCodeLabel.AutoSize = true;
            this.RoomCodeLabel.Location = new System.Drawing.Point(6, 71);
            this.RoomCodeLabel.Name = "RoomCodeLabel";
            this.RoomCodeLabel.Size = new System.Drawing.Size(57, 15);
            this.RoomCodeLabel.TabIndex = 3;
            this.RoomCodeLabel.Text = "Password";
            this.RoomCodeLabel.Visible = false;
            // 
            // PublicRadioButton
            // 
            this.PublicRadioButton.AutoSize = true;
            this.PublicRadioButton.Location = new System.Drawing.Point(6, 22);
            this.PublicRadioButton.Name = "PublicRadioButton";
            this.PublicRadioButton.Size = new System.Drawing.Size(58, 19);
            this.PublicRadioButton.TabIndex = 4;
            this.PublicRadioButton.TabStop = true;
            this.PublicRadioButton.Text = "Public";
            this.PublicRadioButton.UseVisualStyleBackColor = true;
            // 
            // PrivateRadioButton
            // 
            this.PrivateRadioButton.AutoSize = true;
            this.PrivateRadioButton.Location = new System.Drawing.Point(6, 46);
            this.PrivateRadioButton.Name = "PrivateRadioButton";
            this.PrivateRadioButton.Size = new System.Drawing.Size(61, 19);
            this.PrivateRadioButton.TabIndex = 5;
            this.PrivateRadioButton.TabStop = true;
            this.PrivateRadioButton.Text = "Private";
            this.PrivateRadioButton.UseVisualStyleBackColor = true;
            this.PrivateRadioButton.CheckedChanged += new System.EventHandler(this.PrivateRadioButton_CheckedChanged);
            // 
            // RoomModeGroupBox
            // 
            this.RoomModeGroupBox.Controls.Add(this.PublicRadioButton);
            this.RoomModeGroupBox.Controls.Add(this.PrivateRadioButton);
            this.RoomModeGroupBox.Controls.Add(this.PasswordTextBox);
            this.RoomModeGroupBox.Controls.Add(this.RoomCodeLabel);
            this.RoomModeGroupBox.Location = new System.Drawing.Point(52, 44);
            this.RoomModeGroupBox.Name = "RoomModeGroupBox";
            this.RoomModeGroupBox.Size = new System.Drawing.Size(200, 127);
            this.RoomModeGroupBox.TabIndex = 6;
            this.RoomModeGroupBox.TabStop = false;
            this.RoomModeGroupBox.Text = "Room mode";
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Location = new System.Drawing.Point(58, 174);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(61, 15);
            this.SizeLabel.TabIndex = 3;
            this.SizeLabel.Text = "Player size";
            // 
            // SurvivalRadioButton
            // 
            this.SurvivalRadioButton.AutoSize = true;
            this.SurvivalRadioButton.Location = new System.Drawing.Point(6, 22);
            this.SurvivalRadioButton.Name = "SurvivalRadioButton";
            this.SurvivalRadioButton.Size = new System.Drawing.Size(66, 19);
            this.SurvivalRadioButton.TabIndex = 4;
            this.SurvivalRadioButton.TabStop = true;
            this.SurvivalRadioButton.Text = "Survival";
            this.SurvivalRadioButton.UseVisualStyleBackColor = true;
            // 
            // DeathMatchRadioButton
            // 
            this.DeathMatchRadioButton.AutoSize = true;
            this.DeathMatchRadioButton.Location = new System.Drawing.Point(6, 46);
            this.DeathMatchRadioButton.Name = "DeathMatchRadioButton";
            this.DeathMatchRadioButton.Size = new System.Drawing.Size(90, 19);
            this.DeathMatchRadioButton.TabIndex = 5;
            this.DeathMatchRadioButton.TabStop = true;
            this.DeathMatchRadioButton.Text = "Deathmatch";
            this.DeathMatchRadioButton.UseVisualStyleBackColor = true;
            this.DeathMatchRadioButton.CheckedChanged += new System.EventHandler(this.DeathMatchRadioButton_CheckedChanged);
            // 
            // GameModeTextBox
            // 
            this.GameModeTextBox.Controls.Add(this.DurationLabel);
            this.GameModeTextBox.Controls.Add(this.DurationUpDown);
            this.GameModeTextBox.Controls.Add(this.SurvivalRadioButton);
            this.GameModeTextBox.Controls.Add(this.DeathMatchRadioButton);
            this.GameModeTextBox.Location = new System.Drawing.Point(52, 227);
            this.GameModeTextBox.Name = "GameModeTextBox";
            this.GameModeTextBox.Size = new System.Drawing.Size(200, 100);
            this.GameModeTextBox.TabIndex = 6;
            this.GameModeTextBox.TabStop = false;
            this.GameModeTextBox.Text = "Game mode";
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DurationLabel.Location = new System.Drawing.Point(6, 73);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(88, 15);
            this.DurationLabel.TabIndex = 3;
            this.DurationLabel.Text = "Duration (min.)";
            this.DurationLabel.Visible = false;
            // 
            // DurationUpDown
            // 
            this.DurationUpDown.Location = new System.Drawing.Point(100, 68);
            this.DurationUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DurationUpDown.Name = "DurationUpDown";
            this.DurationUpDown.Size = new System.Drawing.Size(38, 23);
            this.DurationUpDown.TabIndex = 8;
            this.DurationUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DurationUpDown.Visible = false;
            // 
            // RoomSizeUpDown
            // 
            this.RoomSizeUpDown.Location = new System.Drawing.Point(58, 192);
            this.RoomSizeUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RoomSizeUpDown.Name = "RoomSizeUpDown";
            this.RoomSizeUpDown.Size = new System.Drawing.Size(188, 23);
            this.RoomSizeUpDown.TabIndex = 8;
            this.RoomSizeUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // RoomCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 379);
            this.Controls.Add(this.RoomSizeUpDown);
            this.Controls.Add(this.GameModeTextBox);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.RoomModeGroupBox);
            this.Controls.Add(this.CreateRoomButton);
            this.Controls.Add(this.CreateRoomLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RoomCreateForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create";
            this.RoomModeGroupBox.ResumeLayout(false);
            this.RoomModeGroupBox.PerformLayout();
            this.GameModeTextBox.ResumeLayout(false);
            this.GameModeTextBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DurationUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomSizeUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreateRoomLabel;
        private System.Windows.Forms.Button CreateRoomButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label RoomCodeLabel;
        private System.Windows.Forms.RadioButton PublicRadioButton;
        private System.Windows.Forms.RadioButton PrivateRadioButton;
        private System.Windows.Forms.GroupBox RoomModeGroupBox;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.RadioButton SurvivalRadioButton;
        private System.Windows.Forms.RadioButton DeathMatchRadioButton;
        private System.Windows.Forms.GroupBox GameModeTextBox;
        private System.Windows.Forms.NumericUpDown RoomSizeUpDown;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.NumericUpDown DurationUpDown;
    }
}