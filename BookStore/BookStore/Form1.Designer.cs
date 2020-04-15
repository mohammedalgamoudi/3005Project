namespace BookStore
{
    partial class Login
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
			this.BookDBConn = new System.Data.SqlClient.SqlConnection();
			this.EnterOwnerBtn = new System.Windows.Forms.Button();
			this.EnterUserBtn = new System.Windows.Forms.Button();
			this.UserLabel = new System.Windows.Forms.Label();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.PasswordText = new System.Windows.Forms.TextBox();
			this.UsernameText = new System.Windows.Forms.TextBox();
			this.RegisterBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// BookDBConn
			// 
			this.BookDBConn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Ready2Go\\source\\repo" +
    "s\\BookStore\\BookStore\\BookDB.mdf;Integrated Security=True;Connect Timeout=30";
			this.BookDBConn.FireInfoMessageEventOnUserErrors = false;
			// 
			// EnterOwnerBtn
			// 
			this.EnterOwnerBtn.Location = new System.Drawing.Point(454, 341);
			this.EnterOwnerBtn.Name = "EnterOwnerBtn";
			this.EnterOwnerBtn.Size = new System.Drawing.Size(279, 77);
			this.EnterOwnerBtn.TabIndex = 3;
			this.EnterOwnerBtn.Text = "Enter as Owner";
			this.EnterOwnerBtn.UseVisualStyleBackColor = true;
			this.EnterOwnerBtn.Click += new System.EventHandler(this.EnterOwnerBtn_Click);
			// 
			// EnterUserBtn
			// 
			this.EnterUserBtn.Location = new System.Drawing.Point(69, 341);
			this.EnterUserBtn.Name = "EnterUserBtn";
			this.EnterUserBtn.Size = new System.Drawing.Size(281, 77);
			this.EnterUserBtn.TabIndex = 2;
			this.EnterUserBtn.Text = "Enter as User";
			this.EnterUserBtn.UseVisualStyleBackColor = true;
			this.EnterUserBtn.Click += new System.EventHandler(this.EnterUserBtn_Click);
			// 
			// UserLabel
			// 
			this.UserLabel.Location = new System.Drawing.Point(65, 177);
			this.UserLabel.Name = "UserLabel";
			this.UserLabel.Size = new System.Drawing.Size(166, 36);
			this.UserLabel.TabIndex = 6;
			this.UserLabel.Text = "Username";
			this.UserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// PasswordLabel
			// 
			this.PasswordLabel.Location = new System.Drawing.Point(65, 252);
			this.PasswordLabel.Name = "PasswordLabel";
			this.PasswordLabel.Size = new System.Drawing.Size(166, 36);
			this.PasswordLabel.TabIndex = 7;
			this.PasswordLabel.Text = "Password";
			this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// PasswordText
			// 
			this.PasswordText.Location = new System.Drawing.Point(315, 257);
			this.PasswordText.Name = "PasswordText";
			this.PasswordText.PasswordChar = '*';
			this.PasswordText.Size = new System.Drawing.Size(279, 26);
			this.PasswordText.TabIndex = 1;
			// 
			// UsernameText
			// 
			this.UsernameText.Location = new System.Drawing.Point(315, 182);
			this.UsernameText.Name = "UsernameText";
			this.UsernameText.Size = new System.Drawing.Size(279, 26);
			this.UsernameText.TabIndex = 0;
			// 
			// RegisterBtn
			// 
			this.RegisterBtn.Location = new System.Drawing.Point(69, 41);
			this.RegisterBtn.Name = "RegisterBtn";
			this.RegisterBtn.Size = new System.Drawing.Size(281, 76);
			this.RegisterBtn.TabIndex = 4;
			this.RegisterBtn.Text = "Not a User? Register";
			this.RegisterBtn.UseVisualStyleBackColor = true;
			this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.RegisterBtn);
			this.Controls.Add(this.UsernameText);
			this.Controls.Add(this.PasswordText);
			this.Controls.Add(this.PasswordLabel);
			this.Controls.Add(this.UserLabel);
			this.Controls.Add(this.EnterOwnerBtn);
			this.Controls.Add(this.EnterUserBtn);
			this.Name = "Login";
			this.Text = "Look Inna Book Store";
			this.Load += new System.EventHandler(this.Login_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Data.SqlClient.SqlConnection BookDBConn;
        private System.Windows.Forms.Button EnterOwnerBtn;
        private System.Windows.Forms.Button EnterUserBtn;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.TextBox UsernameText;
        private System.Windows.Forms.Button RegisterBtn;
    }
}

