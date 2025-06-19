namespace Panti_Asuhan_Role_Admin
{
    partial class Anak_Asuh
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
            labelkelolaanakasuh = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            dataGridViewanakasuh = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttondashboardA = new Button();
            buttontambahanakasuh = new Button();
            buttoncarianakasuh = new Button();
            textBoxnamaanak = new TextBox();
            comboBoxjeniskelamin = new ComboBox();
            labelnamaanak2 = new Label();
            textBoxusia = new TextBox();
            labelusia = new Label();
            dateTimePickertgllahir = new DateTimePicker();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewComboBoxColumn();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewanakasuh).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelkelolaanakasuh
            // 
            labelkelolaanakasuh.AutoSize = true;
            labelkelolaanakasuh.BackColor = Color.MediumAquamarine;
            labelkelolaanakasuh.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelkelolaanakasuh.Location = new Point(199, 78);
            labelkelolaanakasuh.Name = "labelkelolaanakasuh";
            labelkelolaanakasuh.Size = new Size(312, 51);
            labelkelolaanakasuh.TabIndex = 10;
            labelkelolaanakasuh.Text = "Kelola Anak Asuh";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.MediumAquamarine;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Location = new Point(182, 25);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(597, 208);
            tableLayoutPanel2.TabIndex = 9;
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(dataGridViewanakasuh);
            flowLayoutPanel1.Location = new Point(185, 236);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(593, 201);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // dataGridViewanakasuh
            // 
            dataGridViewanakasuh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewanakasuh.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewanakasuh.Location = new Point(3, 3);
            dataGridViewanakasuh.Name = "dataGridViewanakasuh";
            dataGridViewanakasuh.RowHeadersWidth = 62;
            dataGridViewanakasuh.Size = new Size(590, 201);
            dataGridViewanakasuh.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.BackColor = Color.MediumAquamarine;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(buttondashboardA, 0, 0);
            tableLayoutPanel1.Location = new Point(21, 25);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.64637F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 87.35363F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 328F));
            tableLayoutPanel1.Size = new Size(145, 412);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // buttondashboardA
            // 
            buttondashboardA.Location = new Point(3, 3);
            buttondashboardA.Name = "buttondashboardA";
            buttondashboardA.Size = new Size(112, 34);
            buttondashboardA.TabIndex = 2;
            buttondashboardA.Text = "Dashboard";
            buttondashboardA.UseVisualStyleBackColor = true;
            // 
            // buttontambahanakasuh
            // 
            buttontambahanakasuh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttontambahanakasuh.Location = new Point(678, 142);
            buttontambahanakasuh.Name = "buttontambahanakasuh";
            buttontambahanakasuh.Size = new Size(91, 34);
            buttontambahanakasuh.TabIndex = 11;
            buttontambahanakasuh.Text = "Tambah";
            buttontambahanakasuh.UseVisualStyleBackColor = true;
            // 
            // buttoncarianakasuh
            // 
            buttoncarianakasuh.Location = new Point(584, 143);
            buttoncarianakasuh.Name = "buttoncarianakasuh";
            buttoncarianakasuh.Size = new Size(89, 34);
            buttoncarianakasuh.TabIndex = 12;
            buttoncarianakasuh.Text = "Cari";
            buttoncarianakasuh.UseVisualStyleBackColor = true;
            // 
            // textBoxnamaanak
            // 
            textBoxnamaanak.Location = new Point(191, 188);
            textBoxnamaanak.Name = "textBoxnamaanak";
            textBoxnamaanak.Size = new Size(140, 23);
            textBoxnamaanak.TabIndex = 13;
            // 
            // comboBoxjeniskelamin
            // 
            comboBoxjeniskelamin.FormattingEnabled = true;
            comboBoxjeniskelamin.Items.AddRange(new object[] { "Laki - Laki", "Perempuan" });
            comboBoxjeniskelamin.Location = new Point(337, 187);
            comboBoxjeniskelamin.Name = "comboBoxjeniskelamin";
            comboBoxjeniskelamin.Size = new Size(143, 23);
            comboBoxjeniskelamin.TabIndex = 14;
            comboBoxjeniskelamin.Text = "Jenis Kelamin";
            // 
            // labelnamaanak2
            // 
            labelnamaanak2.AutoSize = true;
            labelnamaanak2.BackColor = Color.MediumAquamarine;
            labelnamaanak2.Location = new Point(193, 158);
            labelnamaanak2.Name = "labelnamaanak2";
            labelnamaanak2.Size = new Size(39, 15);
            labelnamaanak2.TabIndex = 15;
            labelnamaanak2.Text = "Nama";
            // 
            // textBoxusia
            // 
            textBoxusia.Location = new Point(486, 189);
            textBoxusia.Name = "textBoxusia";
            textBoxusia.Size = new Size(66, 23);
            textBoxusia.TabIndex = 16;
            // 
            // labelusia
            // 
            labelusia.AutoSize = true;
            labelusia.BackColor = Color.MediumAquamarine;
            labelusia.Location = new Point(490, 159);
            labelusia.Name = "labelusia";
            labelusia.Size = new Size(29, 15);
            labelusia.TabIndex = 17;
            labelusia.Text = "Usia";
            // 
            // dateTimePickertgllahir
            // 
            dateTimePickertgllahir.Location = new Point(563, 188);
            dateTimePickertgllahir.Name = "dateTimePickertgllahir";
            dateTimePickertgllahir.Size = new Size(200, 23);
            dateTimePickertgllahir.TabIndex = 18;
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
            Column3.HeaderText = "Jenis Kelamin";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Visible = false;
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Status";
            Column4.Items.AddRange(new object[] { "Aktif", "Diadopsi" });
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Visible = false;
            Column4.Width = 150;
            // 
            // Anak_Asuh
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.Honeydew;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePickertgllahir);
            Controls.Add(labelusia);
            Controls.Add(textBoxusia);
            Controls.Add(labelnamaanak2);
            Controls.Add(comboBoxjeniskelamin);
            Controls.Add(textBoxnamaanak);
            Controls.Add(buttoncarianakasuh);
            Controls.Add(buttontambahanakasuh);
            Controls.Add(labelkelolaanakasuh);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(tableLayoutPanel1);
            Name = "Anak_Asuh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Anak_Asuh";
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewanakasuh).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelkelolaanakasuh;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView dataGridViewanakasuh;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttondashboardA;
        private Button buttontambahanakasuh;
        private Button buttoncarianakasuh;
        private TextBox textBoxnamaanak;
        private ComboBox comboBoxjeniskelamin;
        private Label labelnamaanak2;
        private TextBox textBoxusia;
        private Label labelusia;
        private DateTimePicker dateTimePickertgllahir;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewComboBoxColumn Column4;
    }
}