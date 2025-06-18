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

        /* ctor kosong */
        public Donatur() : this(null) { }

        /* ctor utama */
        public Donatur(Form? dashboard)
        {
            InitializeComponent();
            _dashboard = dashboard;

            Load += Donatur_Load;
            buttoncariDO.Click += buttonCari_Click;

            // Navigasi
            buttondashboardA.Click += (s, e) =>
            {
                _dashboard?.Show();
                Close();
            };
            //buttonanakasuhDO.Click += (s, e) =>
            //{
            //    var anakForm = new Anak_Asuh(this); // lempar Donatur sebagai parent, bukan dashboard
            //    anakForm.Show();
            //    Hide();
            //};
        }

        /* -------------- LOAD DATA GRID -------------- */
        private void Donatur_Load(object? sender, EventArgs e)
        {
            dataGridViewdonatur.DataSource = _ctrl.TampilSemuaDonatur();
        }

        /* -------------- TOMBOL CARI ----------------- */
        private void buttonCari_Click(object? sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Masukkan username yang ingin dicari.", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var donor = _ctrl.CariDonaturByusername(username);   // ← panggil controller

            dataGridViewdonatur.DataSource = donor != null
                ? new List<DonaturModel> { donor }
                : null;

            if (donor == null)
                MessageBox.Show("Donatur tidak ditemukan.");
        }

    }
}
