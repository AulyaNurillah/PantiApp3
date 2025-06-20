using PantiApp3.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PantiApp3.Views.Donatur
{
    public partial class TambahTunai : Form
    {
        public string JenisDonasi { get; set; }
        public int JumlahDonasi { get; set; }
        private User currentUser;
        private Donasi dataDonasi;

        public TambahTunai(User user)
        {
            InitializeComponent();
            currentUser = user;

            btninput_donasi.Click += btninput_donasi_Click;
            btnkembali.Click += btnkembali_Click;
            tbjumlah_tunai.Enter += tbjumlah_tunai_Enter;
            tbjumlah_tunai.Leave += tbjumlah_tunai_Leave;
        }

        private void btninput_donasi_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbjumlah_tunai.Text, out int jumlah) && jumlah > 99)
            {
                int idUser = currentUser.IdUser;
                dataDonasi = new Donasi("Uang", jumlah, idUser);
                var formSelanjutnya = new CheckTunai(dataDonasi, currentUser);
                formSelanjutnya.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Inputan tidak valid. Jumlah tunai minimal Rp 100.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnkembali_Click(object sender, EventArgs e)
        {
            new DonaturDashboard(currentUser).Show();
            this.Close();
        }

        private void tbjumlah_tunai_Enter(object sender, EventArgs e)
        {
            if (tbjumlah_tunai.Text == "Masukkan Jumlah Nominal...")
            {
                tbjumlah_tunai.Text = "";
                tbjumlah_tunai.ForeColor = Color.Black;
            }
        }

        private void tbjumlah_tunai_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbjumlah_tunai.Text))
            {
                tbjumlah_tunai.Text = "Masukkan Jumlah Nominal...";
                tbjumlah_tunai.ForeColor = Color.Gray;
            }
        }
    }
}
