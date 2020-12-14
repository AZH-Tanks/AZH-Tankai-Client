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
            this.UndoButton.Location = new System.Drawing.Point(712, 528);
            this.UndoButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(86, 31);
            this.UndoButton.TabIndex = 7;
            this.UndoButton.Text = "Undo";
            this.UndoButton.UseVisualStyleBackColor = true;
            this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // SendImageButton
            // 
            this.SendImageButton.Location = new System.Drawing.Point(608, 528);
            this.SendImageButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SendImageButton.Name = "SendImageButton";
            this.SendImageButton.Size = new System.Drawing.Size(97, 31);
            this.SendImageButton.TabIndex = 6;
            this.SendImageButton.Text = "Send image";
            this.SendImageButton.UseVisualStyleBackColor = true;
            this.SendImageButton.Click += new System.EventHandler(this.SendImageButton_Click);
            // 
            // ChatRichTextBox
            // 
            this.ChatRichTextBox.Location = new System.Drawing.Point(7, 20);
            this.ChatRichTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChatRichTextBox.Name = "ChatRichTextBox";
            this.ChatRichTextBox.ReadOnly = true;
            this.ChatRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ChatRichTextBox.Size = new System.Drawing.Size(790, 500);
            this.ChatRichTextBox.TabIndex = 3;
            this.ChatRichTextBox.Text = "";
            // 
            // TextTextBox
            // 
            this.TextTextBox.Location = new System.Drawing.Point(7, 529);
            this.TextTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextTextBox.Name = "TextTextBox";
            this.TextTextBox.Size = new System.Drawing.Size(490, 27);
            this.TextTextBox.TabIndex = 4;
            // 
            // SendTextButton
            // 
            this.SendTextButton.Location = new System.Drawing.Point(504, 528);
            this.SendTextButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SendTextButton.Name = "SendTextButton";
            this.SendTextButton.Size = new System.Drawing.Size(97, 31);
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
            this.groupBox1.Location = new System.Drawing.Point(274, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(805, 575);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Players";
            // 
            // PlayersListBox
            // 
            this.PlayersListBox.FormattingEnabled = true;
            this.PlayersListBox.ItemHeight = 20;
            this.PlayersListBox.Location = new System.Drawing.Point(14, 80);
            this.PlayersListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PlayersListBox.Name = "PlayersListBox";
            this.PlayersListBox.Size = new System.Drawing.Size(253, 444);
            this.PlayersListBox.TabIndex = 2;
            // 
            // RemoveSelectedButton
            // 
            this.RemoveSelectedButton.Location = new System.Drawing.Point(14, 545);
            this.RemoveSelectedButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RemoveSelectedButton.Name = "RemoveSelectedButton";
            this.RemoveSelectedButton.Size = new System.Drawing.Size(254, 31);
            this.RemoveSelectedButton.TabIndex = 9;
            this.RemoveSelectedButton.Text = "Remove selected player";
            this.RemoveSelectedButton.UseVisualStyleBackColor = true;
            // 
            // JoinCodeLabel
            // 
            this.JoinCodeLabel.AutoSize = true;
            this.JoinCodeLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.JoinCodeLabel.Location = new System.Drawing.Point(91, 592);
            this.JoinCodeLabel.Name = "JoinCodeLabel";
            this.JoinCodeLabel.Size = new System.Drawing.Size(0, 35);
            this.JoinCodeLabel.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(402, 599);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(327, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 592);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 35);
            this.label2.TabIndex = 12;
            this.label2.Text = "Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(761, 595);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 35);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mode:";
            // 
            // ModeLabel
            // 
            this.ModeLabel.AutoSize = true;
            this.ModeLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ModeLabel.Location = new System.Drawing.Point(846, 595);
            this.ModeLabel.Name = "ModeLabel";
            this.ModeLabel.Size = new System.Drawing.Size(0, 35);
            this.ModeLabel.TabIndex = 13;
            // 
            // GameLobbyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 641);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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