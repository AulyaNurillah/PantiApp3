using PantiApp3.Controllers;
using PantiApp3.Models;
using PantiApp3.Views;
using System;
using System.Windows.Forms;

namespace PantiApp3.Views
{
    public partial class PengeluaranView : Form
    {
        private readonly PengeluaranController controller = new PengeluaranController();

        public PengeluaranView()
        {
            InitializeComponent();
            LoadData();
            BindEvents();
        }

        private void BindEvents()
        {
            btnTambah.Click += btnTambah_Click;
            btnEdit.Click += btnEdit_Click;
            btnHapus.Click += btnHapus_Click;
        }

        private void LoadData()
        {
            dgvPengeluaran.DataSource = controller.GetAllPengeluaran();
            dgvPengeluaran.Visible = true;
            panelForm.Visible = false;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            dgvPengeluaran.Visible = false;
            panelForm.Controls.Clear();

            var form = new InputPengeluaran();
            form.Dock = DockStyle.Fill;
            form.OnDataSaved += LoadData;
            panelForm.Controls.Add(form);
            panelForm.Visible = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPengeluaran.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data yang ingin diedit.");
                return;
            }

            var row = dgvPengeluaran.SelectedRows[0];
            if (row.DataBoundItem is Pengeluaran selected)
            {
                dgvPengeluaran.Visible = false;
                panelForm.Controls.Clear();

                var form = new InputPengeluaran(selected);
                form.Dock = DockStyle.Fill;
                form.OnDataSaved += LoadData;
                panelForm.Controls.Add(form);
                panelForm.Visible = true;
            }
            else
            {
                MessageBox.Show("❌ Gagal membaca data. Pastikan model data benar.");
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvPengeluaran.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data yang ingin dihapus.");
                return;
            }

            var selected = (Pengeluaran)dgvPengeluaran.SelectedRows[0].DataBoundItem;
            if (MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                controller.Delete(selected.IdPengeluaran);
                LoadData();
            }
        }
    }
}
