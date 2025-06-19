using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Panti_Asuhan_Role_Admin.Controller;
using Panti_Asuhan_Role_Admin.Model;

namespace Panti_Asuhan_Role_Admin
{
    public partial class Donatur : Form
    {
        private readonly Donatur_controller _ctrl = new Donatur_controller();
        private readonly Form? _dashboard;

      
        public Donatur() : this(null) { }

        
        public Donatur(Form? dashboard)
        {
            InitializeComponent();
            _dashboard = dashboard;

            Load += Donatur_Load;
            buttoncariDO.Click += buttonCari_Click;

           
            buttondashboardA.Click += (s, e) =>
            {
                _dashboard?.Show();
                Close();
            };
            
        }


        private void Donatur_Load(object? sender, EventArgs e)
        {
            dataGridViewdonatur.DataSource = _ctrl.TampilSemuaDonatur();

            // Event handler untuk format mata uang
            dataGridViewdonatur.CellFormatting += DataGridViewdonatur_CellFormatting;

            // Header kolom
            if (dataGridViewdonatur.Columns["TotalDonasiUang"] != null)
            {
                dataGridViewdonatur.Columns["TotalDonasiUang"].HeaderText = "Total Donasi Uang";
            }

            // Sembunyikan kolom password
            if (dataGridViewdonatur.Columns["Password"] != null)
            {
                dataGridViewdonatur.Columns["Password"].Visible = false;
            }
        }

        // Dipindahkan ke luar method Donatur_Load
        private void DataGridViewdonatur_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewdonatur.Columns[e.ColumnIndex].Name == "TotalDonasiUang" && e.Value is int jumlah)
            {
                e.Value = $"Rp{jumlah:N0}";  // Format ke Rupiah
                e.FormattingApplied = true;
            }
        }




        private void buttonCari_Click(object? sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Masukkan username yang ingin dicari.", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var donor = _ctrl.CariDonaturByusername(username);   

            dataGridViewdonatur.DataSource = donor != null
                ? new List<DonaturModel> { donor }
                : null;

            if (donor == null)
                MessageBox.Show("Donatur tidak ditemukan.");
        }

    }
}
