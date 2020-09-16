namespace signalrClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OutputBox = new System.Windows.Forms.RichTextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.CreatePlayerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OutputBox
            // 
            this.OutputBox.BackColor = System.Drawing.Color.White;
            this.OutputBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.OutputBox.Location = new System.Drawing.Point(12, 65);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.Size = new System.Drawing.Size(401, 521);
            this.OutputBox.TabIndex = 8;
            this.OutputBox.Text = "";
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.White;
            this.username.Location = new System.Drawing.Point(12, 27);
            this.username.Name = "username";
            this.username.PlaceholderText = "Name..";
            this.username.Size = new System.Drawing.Size(308, 27);
            this.username.TabIndex = 10;
            // 
            // CreatePlayerButton
            // 
            this.CreatePlayerButton.Location = new System.Drawing.Point(326, 27);
            this.CreatePlayerButton.Name = "CreatePlayerButton";
            this.CreatePlayerButton.Size = new System.Drawing.Size(87, 27);
            this.CreatePlayerButton.TabIndex = 11;
            this.CreatePlayerButton.Text = "Submit";
            this.CreatePlayerButton.UseVisualStyleBackColor = true;
            this.CreatePlayerButton.Click += new System.EventHandler(this.CreatePlayerButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 600);
            this.Controls.Add(this.CreatePlayerButton);
            this.Controls.Add(this.username);
            this.Controls.Add(this.OutputBox);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox OutputBox;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button CreatePlayerButton;
    }
}

