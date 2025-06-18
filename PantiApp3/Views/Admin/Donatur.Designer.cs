namespace Panti_Asuhan_Role_Admin
{
    partial class Donatur
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
            labelkeloldonatur = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            dataGridViewdonatur = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttondashboardA = new Button();
            textBox1 = new TextBox();
            labeldonatur2 = new Label();
            buttoncariDO = new Button();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewdonatur).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelkeloldonatur
            // 
            labelkeloldonatur.AutoSize = true;
            labelkeloldonatur.BackColor = Color.MediumAquamarine;
            labelkeloldonatur.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelkeloldonatur.Location = new Point(199, 78);
            labelkeloldonatur.Name = "labelkeloldonatur";
            labelkeloldonatur.Size = new Size(368, 74);
            labelkeloldonatur.TabIndex = 14;
            labelkeloldonatur.Text = "Lihat Donatur";
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
            tableLayoutPanel2.TabIndex = 13;
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
            flowLayoutPanel1.Controls.Add(dataGridViewdonatur);
            flowLayoutPanel1.Location = new Point(185, 236);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(593, 201);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // dataGridViewdonatur
            // 
            dataGridViewdonatur.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewdonatur.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewdonatur.Location = new Point(3, 3);
            dataGridViewdonatur.Name = "dataGridViewdonatur";
            dataGridViewdonatur.RowHeadersWidth = 62;
            dataGridViewdonatur.Size = new Size(590, 198);
            dataGridViewdonatur.TabIndex = 1;
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
            tableLayoutPanel1.Controls.Add(buttondashboardA, 0, 0);
            tableLayoutPanel1.Location = new Point(21, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.64637F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 87.35363F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 328F));
            tableLayoutPanel1.Size = new Size(138, 427);
            tableLayoutPanel1.TabIndex = 11;
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
            // textBox1
            // 
            textBox1.Location = new Point(189, 191);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(169, 31);
            textBox1.TabIndex = 15;
            // 
            // labeldonatur2
            // 
            labeldonatur2.AutoSize = true;
            labeldonatur2.BackColor = Color.MediumAquamarine;
            labeldonatur2.Location = new Point(192, 159);
            labeldonatur2.Name = "labeldonatur2";
            labeldonatur2.Size = new Size(91, 25);
            labeldonatur2.TabIndex = 16;
            labeldonatur2.Text = "Username";
            // 
            // buttoncariDO
            // 
            buttoncariDO.Location = new Point(372, 189);
            buttoncariDO.Name = "buttoncariDO";
            buttoncariDO.Size = new Size(112, 34);
            buttoncariDO.TabIndex = 17;
            buttoncariDO.Text = "Cari";
            buttoncariDO.UseVisualStyleBackColor = true;
            // 
            // Donatur
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttoncariDO);
            Controls.Add(labeldonatur2);
            Controls.Add(textBox1);
            Controls.Add(labelkeloldonatur);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(tableLayoutPanel1);
            Name = "Donatur";
            Text = "Donatur";
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewdonatur).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelkeloldonatur;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView dataGridViewdonatur;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttondashboardA;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private TextBox textBox1;
        private Label labeldonatur2;
        private Button buttoncariDO;
    }
}