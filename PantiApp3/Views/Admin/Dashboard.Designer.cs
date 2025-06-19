namespace Panti_Asuhan_Role_Admin
{
    partial class Dashboard
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
            buttonanakasuhD = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttondonaturD = new Button();
            buttonpengurusP = new Button();
            buttonlogout = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            labeldashboard = new Label();
            textBoxnamaD = new TextBox();
            labelnama = new Label();
            buttoncariD = new Button();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // buttonanakasuhD
            // 
            buttonanakasuhD.Location = new Point(3, 3);
            buttonanakasuhD.Name = "buttonanakasuhD";
            buttonanakasuhD.Size = new Size(112, 34);
            buttonanakasuhD.TabIndex = 2;
            buttonanakasuhD.Text = "Anak Asuh";
            buttonanakasuhD.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.MediumAquamarine;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(buttonanakasuhD, 0, 0);
            tableLayoutPanel1.Controls.Add(buttondonaturD, 0, 1);
            tableLayoutPanel1.Controls.Add(buttonpengurusP, 0, 2);
            tableLayoutPanel1.Location = new Point(15, 13);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.Size = new Size(138, 427);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // buttondonaturD
            // 
            buttondonaturD.Location = new Point(3, 48);
            buttondonaturD.Name = "buttondonaturD";
            buttondonaturD.Size = new Size(112, 34);
            buttondonaturD.TabIndex = 1;
            buttondonaturD.Text = "Donatur";
            buttondonaturD.UseVisualStyleBackColor = true;
            // 
            // buttonpengurusP
            // 
            buttonpengurusP.Location = new Point(3, 93);
            buttonpengurusP.Name = "buttonpengurusP";
            buttonpengurusP.Size = new Size(112, 34);
            buttonpengurusP.TabIndex = 3;
            buttonpengurusP.Text = "Bendahara";
            buttonpengurusP.UseVisualStyleBackColor = true;
            // 
            // buttonlogout
            // 
            buttonlogout.BackColor = Color.IndianRed;
            buttonlogout.ForeColor = Color.Black;
            buttonlogout.Location = new Point(21, 157);
            buttonlogout.Name = "buttonlogout";
            buttonlogout.Size = new Size(111, 36);
            buttonlogout.TabIndex = 10;
            buttonlogout.Text = "Logout";
            buttonlogout.UseVisualStyleBackColor = true;
            buttonlogout.Click += buttonlogout_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(dataGridView1);
            flowLayoutPanel1.Location = new Point(179, 237);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(593, 201);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(590, 198);
            dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Visible = false;
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nama";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Visible = false;
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "Role";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Visible = false;
            Column3.Width = 150;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.MediumAquamarine;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Location = new Point(176, 26);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(597, 200);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 15);
            label1.TabIndex = 0;
            label1.Text = "Selamat Datang Admin";
            // 
            // labeldashboard
            // 
            labeldashboard.AutoSize = true;
            labeldashboard.BackColor = Color.MediumAquamarine;
            labeldashboard.Font = new Font("Segoe UI", 36F);
            labeldashboard.Location = new Point(189, 57);
            labeldashboard.Name = "labeldashboard";
            labeldashboard.Size = new Size(271, 65);
            labeldashboard.TabIndex = 6;
            labeldashboard.Text = "Dashboard ";
            // 
            // textBoxnamaD
            // 
            textBoxnamaD.Location = new Point(183, 190);
            textBoxnamaD.Name = "textBoxnamaD";
            textBoxnamaD.Size = new Size(150, 23);
            textBoxnamaD.TabIndex = 7;
            // 
            // labelnama
            // 
            labelnama.AutoSize = true;
            labelnama.BackColor = Color.MediumAquamarine;
            labelnama.Location = new Point(186, 163);
            labelnama.Name = "labelnama";
            labelnama.Size = new Size(39, 15);
            labelnama.TabIndex = 8;
            labelnama.Text = "Nama";
            // 
            // buttoncariD
            // 
            buttoncariD.Location = new Point(339, 189);
            buttoncariD.Name = "buttoncariD";
            buttoncariD.Size = new Size(112, 34);
            buttoncariD.TabIndex = 9;
            buttoncariD.Text = "Cari";
            buttoncariD.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.Honeydew;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonlogout);
            Controls.Add(buttoncariD);
            Controls.Add(labelnama);
            Controls.Add(textBoxnamaD);
            Controls.Add(labeldashboard);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(tableLayoutPanel1);
            Name = "Dashboard";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonanakasuhD;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttondonaturD;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label labeldashboard;
        private TextBox textBoxnamaD;
        private Label labelnama;
        private Button buttoncariD;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button buttonpengurusP;
        private Button buttonlogout; // Tambahan
    }
}
