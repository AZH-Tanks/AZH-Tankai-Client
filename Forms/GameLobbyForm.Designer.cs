namespace AZH_Tankai_Client.Forms
{
    partial class GameLobbyForm
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
            this.UndoButton = new System.Windows.Forms.Button();
            this.SendImageButton = new System.Windows.Forms.Button();
            this.ChatRichTextBox = new System.Windows.Forms.RichTextBox();
            this.TextTextBox = new System.Windows.Forms.TextBox();
            this.SendTextButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PlayersListBox = new System.Windows.Forms.ListBox();
            this.RemoveSelectedButton = new System.Windows.Forms.Button();
            this.JoinCodeLabel = new System.Windows.Forms.Label();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ModeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UndoButton
            // 
            this.UndoButton.Location = new System.Drawing.Point(623, 396);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(75, 23);
            this.UndoButton.TabIndex = 7;
            this.UndoButton.Text = "Undo";
            this.UndoButton.UseVisualStyleBackColor = true;
            this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // SendImageButton
            // 
            this.SendImageButton.Location = new System.Drawing.Point(532, 396);
            this.SendImageButton.Name = "SendImageButton";
            this.SendImageButton.Size = new System.Drawing.Size(85, 23);
            this.SendImageButton.TabIndex = 6;
            this.SendImageButton.Text = "Send image";
            this.SendImageButton.UseVisualStyleBackColor = true;
            this.SendImageButton.Click += new System.EventHandler(this.SendImageButton_Click);
            // 
            // ChatRichTextBox
            // 
            this.ChatRichTextBox.Location = new System.Drawing.Point(6, 15);
            this.ChatRichTextBox.Name = "ChatRichTextBox";
            this.ChatRichTextBox.ReadOnly = true;
            this.ChatRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ChatRichTextBox.Size = new System.Drawing.Size(692, 376);
            this.ChatRichTextBox.TabIndex = 3;
            this.ChatRichTextBox.Text = "";
            // 
            // TextTextBox
            // 
            this.TextTextBox.Location = new System.Drawing.Point(6, 397);
            this.TextTextBox.Name = "TextTextBox";
            this.TextTextBox.Size = new System.Drawing.Size(429, 23);
            this.TextTextBox.TabIndex = 4;
            // 
            // SendTextButton
            // 
            this.SendTextButton.Location = new System.Drawing.Point(441, 396);
            this.SendTextButton.Name = "SendTextButton";
            this.SendTextButton.Size = new System.Drawing.Size(85, 23);
            this.SendTextButton.TabIndex = 5;
            this.SendTextButton.Text = "Send text";
            this.SendTextButton.UseVisualStyleBackColor = true;
            this.SendTextButton.Click += new System.EventHandler(this.SendTextButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UndoButton);
            this.groupBox1.Controls.Add(this.SendImageButton);
            this.groupBox1.Controls.Add(this.ChatRichTextBox);
            this.groupBox1.Controls.Add(this.TextTextBox);
            this.groupBox1.Controls.Add(this.SendTextButton);
            this.groupBox1.Location = new System.Drawing.Point(240, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 431);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Players";
            // 
            // PlayersListBox
            // 
            this.PlayersListBox.FormattingEnabled = true;
            this.PlayersListBox.ItemHeight = 15;
            this.PlayersListBox.Location = new System.Drawing.Point(12, 60);
            this.PlayersListBox.Name = "PlayersListBox";
            this.PlayersListBox.Size = new System.Drawing.Size(222, 334);
            this.PlayersListBox.TabIndex = 2;
            // 
            // RemoveSelectedButton
            // 
            this.RemoveSelectedButton.Location = new System.Drawing.Point(12, 409);
            this.RemoveSelectedButton.Name = "RemoveSelectedButton";
            this.RemoveSelectedButton.Size = new System.Drawing.Size(222, 23);
            this.RemoveSelectedButton.TabIndex = 9;
            this.RemoveSelectedButton.Text = "Remove selected player";
            this.RemoveSelectedButton.UseVisualStyleBackColor = true;
            // 
            // JoinCodeLabel
            // 
            this.JoinCodeLabel.AutoSize = true;
            this.JoinCodeLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.JoinCodeLabel.Location = new System.Drawing.Point(80, 444);
            this.JoinCodeLabel.Name = "JoinCodeLabel";
            this.JoinCodeLabel.Size = new System.Drawing.Size(0, 28);
            this.JoinCodeLabel.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(352, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(286, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(666, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 28);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mode:";
            // 
            // ModeLabel
            // 
            this.ModeLabel.AutoSize = true;
            this.ModeLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ModeLabel.Location = new System.Drawing.Point(740, 446);
            this.ModeLabel.Name = "ModeLabel";
            this.ModeLabel.Size = new System.Drawing.Size(0, 28);
            this.ModeLabel.TabIndex = 13;
            // 
            // GameLobbyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 481);
            this.Controls.Add(this.ModeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.JoinCodeLabel);
            this.Controls.Add(this.RemoveSelectedButton);
            this.Controls.Add(this.PlayersListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GameLobbyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game Lobby";
            this.Load += new System.EventHandler(this.GameLobbyForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UndoButton;
        private System.Windows.Forms.Button SendImageButton;
        private System.Windows.Forms.RichTextBox ChatRichTextBox;
        private System.Windows.Forms.TextBox TextTextBox;
        private System.Windows.Forms.Button SendTextButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox PlayersListBox;
        private System.Windows.Forms.Button RemoveSelectedButton;
        private System.Windows.Forms.Label JoinCodeLabel;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ModeLabel;
    }
}