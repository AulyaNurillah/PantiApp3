using PantiApp3.Models;
using PantiApp3.Views;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Donatur
{
    public partial class TambahDonasi : Form
    {
        public string JenisDonasi { get; set; }
        public int JumlahDonasi { get; set; }
        private User currentUser;
        private Donasi dataDonasi;

        public TambahDonasi(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void btninput_donasi_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbjumlah_barang.Text, out int jumlah) && jumlah > 0)
            {
                int idUser = currentUser.IdUser;
                dataDonasi = new Donasi(tbjenis_barang.Text, jumlah, idUser);
                var formSelanjutnya = new Setelah_Donasi(dataDonasi, currentUser);
                formSelanjutnya.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Inputan tidak valid. Jumlah harus berupa angka dan lebih dari 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnkembali_Click(object sender, EventArgs e)
        {
            new DonaturDashboard(currentUser).Show();
            this.Hide();
        }

        private void tbjenis_barang_Enter(object sender, EventArgs e)
        {
            if (tbjenis_barang.Text == "Masukkan Jenis Barang...")
            {
                tbjenis_barang.Text = "";
                tbjenis_barang.ForeColor = Color.Black;
            }
        }

        private void tbjenis_barang_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbjenis_barang.Text))
            {
                tbjenis_barang.Text = "Masukkan Jenis Barang...";
                tbjenis_barang.ForeColor = Color.Gray;
            }
        }

        private void tbjumlah_barang_Enter(object sender, EventArgs e)
        {
            if (tbjumlah_barang.Text == "Masukkan Jumlah Barang...")
            {
                tbjumlah_barang.Text = "";
                tbjumlah_barang.ForeColor = Color.Black;
            }
        }

        private void tbjumlah_barang_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbjumlah_barang.Text))
            {
                tbjumlah_barang.Text = "Masukkan Jumlah Barang...";
                tbjumlah_barang.ForeColor = Color.Gray;
            }
        }
    }
}
