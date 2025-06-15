using PantiApp3.Controllers;
using PantiApp3.Models;
using System;
using System.Windows.Forms;

namespace PantiApp3.Views
{
    public partial class PemasukanView : Form
    {
        private readonly PemasukanController controller = new PemasukanController();

        public PemasukanView()
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
            dgvPemasukan.DataSource = controller.GetAllPemasukan();
            dgvPemasukan.Visible = true;
            panelForm.Visible = false;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            dgvPemasukan.Visible = false;
            panelForm.Controls.Clear();

            var inputForm = new InputPemasukan();
            inputForm.Dock = DockStyle.Fill;
            inputForm.OnDataSaved += LoadData;
            panelForm.Controls.Add(inputForm);
            panelForm.Visible = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPemasukan.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data yang ingin diedit.");
                return;
            }

            var row = dgvPemasukan.SelectedRows[0];
            if (row.DataBoundItem is Pemasukan selected)
            {
                dgvPemasukan.Visible = false;
                panelForm.Controls.Clear();

                var form = new InputPemasukan(selected);
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
            if (dgvPemasukan.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data yang ingin dihapus.");
                return;
            }

            var selected = (Pemasukan)dgvPemasukan.SelectedRows[0].DataBoundItem;
            if (MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                controller.Delete(selected.IdPemasukan);
                LoadData();
            }
        }
    }
}
