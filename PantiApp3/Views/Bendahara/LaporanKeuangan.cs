using PantiApp3.Controllers;
using PantiApp3.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PantiApp3.Views
{
    public partial class LaporanKeuanganView : Form
    {
        private readonly LaporanKeuanganController controller = new LaporanKeuanganController();

        public LaporanKeuanganView()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            var data = controller.GetLaporan();
            dgvLaporan.AutoGenerateColumns = true;
            dgvLaporan.DataSource = null;
            dgvLaporan.DataSource = data;

            if (data.Count == 0)
            {
                MessageBox.Show("Data tidak ditemukan di database.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
