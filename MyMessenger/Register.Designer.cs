namespace MyMessenger
{
    partial class Register
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
            Username = new TextBox();
            Number = new TextBox();
            Password = new TextBox();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // Username
            // 
            Username.AccessibleName = "Username";
            Username.Location = new Point(55, 74);
            Username.Name = "Username";
            Username.Size = new Size(206, 23);
            Username.TabIndex = 0;
            Username.Text = "Username";
            // 
            // Number
            // 
            Number.Location = new Point(55, 103);
            Number.Name = "Number";
            Number.Size = new Size(206, 23);
            Number.TabIndex = 2;
            Number.Text = "Number";
            // 
            // Password
            // 
            Password.Location = new Point(55, 132);
            Password.Name = "Password";
            Password.Size = new Size(206, 23);
            Password.TabIndex = 3;
            Password.Text = "Password";
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.Location = new Point(55, 161);
            button1.Name = "button1";
            button1.Size = new Size(206, 35);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.SpringGreen;
            linkLabel1.Location = new Point(134, 199);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(37, 15);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(317, 270);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(Password);
            Controls.Add(Number);
            Controls.Add(Username);
            ForeColor = SystemColors.ControlText;
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Username;
        private TextBox Number;
        private TextBox Password;
        private Button button1;
        private LinkLabel linkLabel1;
    }
}