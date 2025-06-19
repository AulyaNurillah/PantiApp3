namespace PantiApp3.Views.Donatur
{
    partial class Profile
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnkembali = new Button();
            panel2 = new Panel();
            btnsimpan = new Button();
            btnLogout = new Button();
            tbpassword = new TextBox();
            label5 = new Label();
            tbno_telp = new TextBox();
            label4 = new Label();
            tbnama = new TextBox();
            label3 = new Label();
            tbid_donatur = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();

            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnkembali);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(757, 83);
            panel1.TabIndex = 2;

            // 
            // btnkembali
            // 
            btnkembali.BackColor = Color.Transparent;
            btnkembali.FlatStyle = FlatStyle.Flat;
            btnkembali.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnkembali.ForeColor = Color.FromArgb(64, 64, 64);
            btnkembali.Location = new Point(44, 12);
            btnkembali.Margin = new Padding(4, 5, 4, 5);
            btnkembali.Name = "btnkembali";
            btnkembali.Size = new Size(147, 62);
            btnkembali.TabIndex = 0;
            btnkembali.Text = "<  Kembali";
            btnkembali.TextAlign = ContentAlignment.TopLeft;
            btnkembali.UseVisualStyleBackColor = false;
            btnkembali.Click += btnkembali_Click;

            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(btnsimpan);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(tbpassword);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(tbno_telp);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(tbnama);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(tbid_donatur);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(81, 120);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(597, 610);
            panel2.TabIndex = 3;

            // 
            // btnsimpan
            // 
            // btnsimpan
            // 
            btnsimpan.BackColor = SystemColors.ButtonShadow;
            btnsimpan.FlatStyle = FlatStyle.Popup;
            btnsimpan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnsimpan.Location = new Point(467, 347);
            btnsimpan.Margin = new Padding(4, 5, 4, 5);
            btnsimpan.Name = "btnsimpan";
            btnsimpan.Size = new Size(100, 38);
            btnsimpan.TabIndex = 10;
            btnsimpan.Text = "simpan";
            btnsimpan.UseVisualStyleBackColor = false;
            btnsimpan.Click += btnsimpan_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Red;
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogout.Location = new Point(211, 515);
            btnLogout.Margin = new Padding(4, 5, 4, 5);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(181, 58);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // tbpassword
            // 
            tbpassword.Location = new Point(44, 438);
            tbpassword.Margin = new Padding(4, 5, 4, 5);
            tbpassword.Name = "tbpassword";
            tbpassword.ReadOnly = true;
            tbpassword.Size = new Size(494, 31);
            tbpassword.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(41, 398);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(103, 30);
            label5.TabIndex = 7;
            label5.Text = "Password";
            // 
            // tbno_telp
            // 
            tbno_telp.Location = new Point(44, 347);
            tbno_telp.Margin = new Padding(4, 5, 4, 5);
            tbno_telp.Name = "tbno_telp";
            tbno_telp.Size = new Size(425, 31);
            tbno_telp.TabIndex = 6;

            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(41, 307);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(125, 30);
            label4.TabIndex = 5;
            label4.Text = "No Telepon";

            // 
            // tbnama
            // 
            tbnama.Location = new Point(44, 255);
            tbnama.Margin = new Padding(4, 5, 4, 5);
            tbnama.Name = "tbnama";
            tbnama.ReadOnly = true;
            tbnama.Size = new Size(494, 31);
            tbnama.TabIndex = 4;

            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(41, 215);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 30);
            label3.TabIndex = 3;
            label3.Text = "Nama";

            // 
            // tbid_donatur
            // 
            tbid_donatur.Location = new Point(44, 167);
            tbid_donatur.Margin = new Padding(4, 5, 4, 5);
            tbid_donatur.Name = "tbid_donatur";
            tbid_donatur.ReadOnly = true;
            tbid_donatur.Size = new Size(494, 31);
            tbid_donatur.TabIndex = 2;

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(41, 127);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(118, 30);
            label2.TabIndex = 1;
            label2.Text = "ID Donatur";

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(36, 42);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(280, 48);
            label1.TabIndex = 0;
            label1.Text = "Profile Donatur";
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 750);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Profile";
            Text = "Profile";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnkembali;
        private Panel panel2;
        private Label label1;
        private TextBox tbid_donatur;
        private Label label2;
        private TextBox tbno_telp;
        private Label label4;
        private TextBox tbnama;
        private Label label3;
        private TextBox tbpassword;
        private Label label5;
        private Button btnLogout;
        private Button btnsimpan;
    }
}
