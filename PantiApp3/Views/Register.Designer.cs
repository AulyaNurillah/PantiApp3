namespace PantiApp3.Views
{
    partial class Register
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbNoTelp;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.LinkLabel linkLogin;

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
            panelMain = new Panel();
            lblUsername = new Label();
            lblTitle = new Label();
            tbName = new TextBox();
            tbNoTelp = new TextBox();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            btnRegister = new Button();
            linkLogin = new LinkLabel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.WhiteSmoke;
            panelMain.BorderStyle = BorderStyle.FixedSingle;
            panelMain.Controls.Add(label3);
            panelMain.Controls.Add(label2);
            panelMain.Controls.Add(label1);
            panelMain.Controls.Add(lblUsername);
            panelMain.Controls.Add(lblTitle);
            panelMain.Controls.Add(tbName);
            panelMain.Controls.Add(tbNoTelp);
            panelMain.Controls.Add(tbUsername);
            panelMain.Controls.Add(tbPassword);
            panelMain.Controls.Add(btnRegister);
            panelMain.Controls.Add(linkLogin);
            panelMain.Location = new Point(230, 25);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(340, 420);
            panelMain.TabIndex = 0;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Sitka Display", 10F);
            lblUsername.Location = new Point(48, 185);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(64, 20);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Sitka Display", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.SteelBlue;
            lblTitle.Location = new Point(127, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(91, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Register";
            // 
            // tbName
            // 
            tbName.Font = new Font("Sitka Display", 10F);
            tbName.ForeColor = Color.SteelBlue;
            tbName.Location = new Point(45, 98);
            tbName.Name = "tbName";
            tbName.Size = new Size(250, 24);
            tbName.TabIndex = 1;
            tbName.Text = "Masukkan Nama lengkap";
            tbName.Enter += txt_Enter;
            tbName.Leave += txt_Leave;
            // 
            // tbNoTelp
            // 
            tbNoTelp.Font = new Font("Sitka Display", 10F);
            tbNoTelp.ForeColor = Color.SteelBlue;
            tbNoTelp.Location = new Point(45, 150);
            tbNoTelp.Name = "tbNoTelp";
            tbNoTelp.Size = new Size(250, 24);
            tbNoTelp.TabIndex = 2;
            tbNoTelp.Text = "Masukkan No Telepon";
            tbNoTelp.Enter += txt_Enter;
            tbNoTelp.Leave += txt_Leave;
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Sitka Display", 10F);
            tbUsername.ForeColor = Color.SteelBlue;
            tbUsername.Location = new Point(45, 207);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(250, 24);
            tbUsername.TabIndex = 3;
            tbUsername.Text = "Masukkan Username";
            tbUsername.Enter += txt_Enter;
            tbUsername.Leave += txt_Leave;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Sitka Display", 10F);
            tbPassword.ForeColor = Color.SteelBlue;
            tbPassword.Location = new Point(45, 260);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(250, 24);
            tbPassword.TabIndex = 4;
            tbPassword.Text = "Masukkan Password";
            tbPassword.Enter += txt_Enter;
            tbPassword.Leave += txt_Leave;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.SteelBlue;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Sitka Display", 10F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(45, 309);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(250, 30);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Daftar";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // linkLogin
            // 
            linkLogin.AutoSize = true;
            linkLogin.Font = new Font("Sitka Display", 9F, FontStyle.Italic);
            linkLogin.LinkColor = Color.SteelBlue;
            linkLogin.Location = new Point(106, 342);
            linkLogin.Name = "linkLogin";
            linkLogin.Size = new Size(130, 18);
            linkLogin.TabIndex = 7;
            linkLogin.TabStop = true;
            linkLogin.Text = "Sudah punya akun? Login";
            linkLogin.LinkClicked += linkLogin_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Display", 10F);
            label1.Location = new Point(48, 76);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 8;
            label1.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Display", 10F);
            label2.Location = new Point(48, 128);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 3;
            label2.Text = "No Telepon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Display", 10F);
            label3.Location = new Point(48, 238);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 9;
            label3.Text = "Password";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 470);
            Controls.Add(panelMain);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }
        private Label lblUsername;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
