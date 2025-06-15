namespace PantiApp3.Views
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.LinkLabel linkRegister;
        private System.Windows.Forms.Label lblMessage;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblTitle = new Label();
            panelLogin = new Panel();
            lblMessage = new Label();
            linkRegister = new LinkLabel();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Sitka Display", 10F);
            lblUsername.Location = new Point(30, 70);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(64, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Sitka Display", 10F);
            txtUsername.ForeColor = Color.SteelBlue;
            txtUsername.Location = new Point(30, 90);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(300, 24);
            txtUsername.TabIndex = 2;
            txtUsername.Text = "Masukkan username";
            txtUsername.Enter += txtUsername_Enter;
            txtUsername.Leave += txtUsername_Leave;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Sitka Display", 10F);
            lblPassword.Location = new Point(30, 130);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(61, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Sitka Display", 10F);
            txtPassword.ForeColor = Color.SteelBlue;
            txtPassword.Location = new Point(30, 150);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(300, 24);
            txtPassword.TabIndex = 4;
            txtPassword.Text = "Masukkan password";
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SteelBlue;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Sitka Display", 10F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(30, 200);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(300, 30);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Sitka Display", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.SteelBlue;
            lblTitle.Location = new Point(140, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(66, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Login";
            // 
            // panelLogin
            // 
            panelLogin.BorderStyle = BorderStyle.FixedSingle;
            panelLogin.Controls.Add(lblTitle);
            panelLogin.Controls.Add(lblUsername);
            panelLogin.Controls.Add(txtUsername);
            panelLogin.Controls.Add(lblPassword);
            panelLogin.Controls.Add(txtPassword);
            panelLogin.Controls.Add(lblMessage);
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Controls.Add(linkRegister);
            panelLogin.Location = new Point(197, 52);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(360, 340);
            panelLogin.TabIndex = 0;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMessage.ForeColor = Color.Red;
            lblMessage.Location = new Point(30, 175);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 15);
            lblMessage.TabIndex = 7;
            // 
            // linkRegister
            // 
            linkRegister.AutoSize = true;
            linkRegister.Font = new Font("Sitka Display", 9F, FontStyle.Italic);
            linkRegister.LinkColor = Color.MediumBlue;
            linkRegister.Location = new Point(105, 237);
            linkRegister.Name = "linkRegister";
            linkRegister.Size = new Size(144, 18);
            linkRegister.TabIndex = 6;
            linkRegister.TabStop = true;
            linkRegister.Text = "Belum punya akun? Register";
            linkRegister.LinkClicked += linkRegister_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelLogin);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login - Sistem Panti Asuhan";
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
        }
    }
}
