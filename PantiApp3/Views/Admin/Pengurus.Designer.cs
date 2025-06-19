namespace Panti_Asuhan_Role_Admin
{
    partial class Pengurus
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
            buttoncariP = new Button();
            labelpengurus2 = new Label();
            textBoxpengurus = new TextBox();
            labellihatpengurus = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            dataGridViewpengurus = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttondashboardP = new Button();
            textBoxusername = new TextBox();
            textBoxpassword = new TextBox();
            textBoxnotelp = new TextBox();
            labelusername = new Label();
            labelpassword = new Label();
            labelnotelp = new Label();
            buttontambahbendahara = new Button();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewpengurus).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttoncariP
            // 
            buttoncariP.Location = new Point(541, 176);
            buttoncariP.Name = "buttoncariP";
            buttoncariP.Size = new Size(74, 38);
            buttoncariP.TabIndex = 24;
            buttoncariP.Text = "Cari";
            buttoncariP.UseVisualStyleBackColor = true;
            // 
            // labelpengurus2
            // 
            labelpengurus2.AutoSize = true;
            labelpengurus2.BackColor = Color.MediumAquamarine;
            labelpengurus2.Location = new Point(192, 169);
            labelpengurus2.Name = "labelpengurus2";
            labelpengurus2.Size = new Size(59, 25);
            labelpengurus2.TabIndex = 23;
            labelpengurus2.Text = "Nama";
            // 
            // textBoxpengurus
            // 
            textBoxpengurus.Location = new Point(189, 191);
            textBoxpengurus.Name = "textBoxpengurus";
            textBoxpengurus.Size = new Size(117, 31);
            textBoxpengurus.TabIndex = 22;
            // 
            // labellihatpengurus
            // 
            labellihatpengurus.AutoSize = true;
            labellihatpengurus.BackColor = Color.MediumAquamarine;
            labellihatpengurus.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labellihatpengurus.Location = new Point(199, 51);
            labellihatpengurus.Name = "labellihatpengurus";
            labellihatpengurus.Size = new Size(457, 74);
            labellihatpengurus.TabIndex = 21;
            labellihatpengurus.Text = "Kelola Bendahara";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.MediumAquamarine;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Location = new Point(182, 25);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(597, 200);
            tableLayoutPanel2.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(196, 25);
            label1.TabIndex = 0;
            label1.Text = "Selamat Datang Admin";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(dataGridViewpengurus);
            flowLayoutPanel1.Location = new Point(185, 236);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(593, 201);
            flowLayoutPanel1.TabIndex = 19;
            // 
            // dataGridViewpengurus
            // 
            dataGridViewpengurus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewpengurus.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewpengurus.Location = new Point(3, 3);
            dataGridViewpengurus.Name = "dataGridViewpengurus";
            dataGridViewpengurus.RowHeadersWidth = 62;
            dataGridViewpengurus.Size = new Size(590, 201);
            dataGridViewpengurus.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Visible = false;
            Column1.Width = 90;
            // 
            // Column2
            // 
            Column2.HeaderText = "Username";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Visible = false;
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Password";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Visible = false;
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "No Telepon";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Visible = false;
            Column4.Width = 150;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.MediumAquamarine;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(buttondashboardP, 0, 0);
            tableLayoutPanel1.Location = new Point(21, 25);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.64637F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 87.35363F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 328F));
            tableLayoutPanel1.Size = new Size(138, 412);
            tableLayoutPanel1.TabIndex = 18;
            // 
            // buttondashboardP
            // 
            buttondashboardP.Location = new Point(3, 3);
            buttondashboardP.Name = "buttondashboardP";
            buttondashboardP.Size = new Size(112, 34);
            buttondashboardP.TabIndex = 2;
            buttondashboardP.Text = "Dashboard";
            buttondashboardP.UseVisualStyleBackColor = true;
            // 
            // textBoxusername
            // 
            textBoxusername.Location = new Point(325, 191);
            textBoxusername.Name = "textBoxusername";
            textBoxusername.Size = new Size(117, 31);
            textBoxusername.TabIndex = 25;
            // 
            // textBoxpassword
            // 
            textBoxpassword.Location = new Point(192, 146);
            textBoxpassword.Name = "textBoxpassword";
            textBoxpassword.Size = new Size(114, 31);
            textBoxpassword.TabIndex = 26;
            // 
            // textBoxnotelp
            // 
            textBoxnotelp.Location = new Point(325, 146);
            textBoxnotelp.Name = "textBoxnotelp";
            textBoxnotelp.Size = new Size(117, 31);
            textBoxnotelp.TabIndex = 27;
            // 
            // labelusername
            // 
            labelusername.AutoSize = true;
            labelusername.BackColor = Color.MediumAquamarine;
            labelusername.Location = new Point(325, 176);
            labelusername.Name = "labelusername";
            labelusername.Size = new Size(91, 25);
            labelusername.TabIndex = 28;
            labelusername.Text = "Username";
            // 
            // labelpassword
            // 
            labelpassword.AutoSize = true;
            labelpassword.BackColor = Color.MediumAquamarine;
            labelpassword.Location = new Point(192, 115);
            labelpassword.Name = "labelpassword";
            labelpassword.Size = new Size(87, 25);
            labelpassword.TabIndex = 29;
            labelpassword.Text = "Password";
            // 
            // labelnotelp
            // 
            labelnotelp.AutoSize = true;
            labelnotelp.BackColor = Color.MediumAquamarine;
            labelnotelp.Location = new Point(322, 120);
            labelnotelp.Name = "labelnotelp";
            labelnotelp.Size = new Size(101, 25);
            labelnotelp.TabIndex = 30;
            labelnotelp.Text = "No.Telepon";
            // 
            // buttontambahbendahara
            // 
            buttontambahbendahara.Location = new Point(624, 176);
            buttontambahbendahara.Name = "buttontambahbendahara";
            buttontambahbendahara.Size = new Size(112, 38);
            buttontambahbendahara.TabIndex = 31;
            buttontambahbendahara.Text = "Tambah";
            buttontambahbendahara.UseVisualStyleBackColor = true;
            // 
            // Pengurus
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.Honeydew;
            ClientSize = new Size(800, 450);
            Controls.Add(buttontambahbendahara);
            Controls.Add(labelnotelp);
            Controls.Add(labelpassword);
            Controls.Add(labelusername);
            Controls.Add(textBoxnotelp);
            Controls.Add(textBoxpassword);
            Controls.Add(textBoxusername);
            Controls.Add(buttoncariP);
            Controls.Add(labelpengurus2);
            Controls.Add(textBoxpengurus);
            Controls.Add(labellihatpengurus);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(tableLayoutPanel1);
            Name = "Pengurus";
            Text = "Pengurus";
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewpengurus).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttoncariP;
        private Label labelpengurus2;
        private TextBox textBoxpengurus;
        private Label labellihatpengurus;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView dataGridViewpengurus;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttondashboardP;
        private TextBox textBoxusername;
        private TextBox textBoxpassword;
        private TextBox textBoxnotelp;
        private Label labelusername;
        private Label labelpassword;
        private Label labelnotelp;
        private Button buttontambahbendahara;
    }
}