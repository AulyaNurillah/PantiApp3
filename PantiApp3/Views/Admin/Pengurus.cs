using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Panti_Asuhan_Role_Admin.Controller;
using Panti_Asuhan_Role_Admin.Model;

namespace Panti_Asuhan_Role_Admin
{
    public partial class Pengurus : Form
    {
        private readonly Pengurus_controller _ctrl = new Pengurus_controller();
        private readonly Form? _dashboard;

        public Pengurus() : this(null) { }

        public Pengurus(Form? dashboard)
        {
            InitializeComponent();
            _dashboard = dashboard;

            Load += Pengurus_Load;
            buttoncariP.Click += buttonCari_Click;
            buttontambahbendahara.Click += buttonTambah_Click; 
            buttondashboardP.Click += (s, e) =>
            {
                _dashboard?.Show();
                Close();
            };
        }

        private void Pengurus_Load(object? sender, EventArgs e)
        {
            TampilkanSemua();
        }

        private void TampilkanSemua()
        {
            dataGridViewpengurus.DataSource = _ctrl.TampilSemuaPengurus();
        }

      
        private void buttonCari_Click(object? sender, EventArgs e)
        {
            string nama = textBoxpengurus.Text.Trim();
            string username = textBoxusername.Text.Trim();
            string password = textBoxpassword.Text.Trim();
            string noTelepon = textBoxnotelp.Text.Trim();

            string keyword = "";
            string kriteria = "";

            if (!string.IsNullOrWhiteSpace(nama))
            {
                keyword = nama;
                kriteria = "nama";
            }
            else if (!string.IsNullOrWhiteSpace(username))
            {
                keyword = username;
                kriteria = "username";
            }
            else if (!string.IsNullOrWhiteSpace(password))
            {
                keyword = password;
                kriteria = "password";
            }
            else if (!string.IsNullOrWhiteSpace(noTelepon))
            {
                keyword = noTelepon;
                kriteria = "telepon";
            }

            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Masukkan salah satu kata kunci untuk pencarian (nama, username, password, atau no.telepon).",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var hasil = _ctrl.PerformCariPengurus(keyword, kriteria);

            if (hasil.Count == 0)
            {
                MessageBox.Show("Tidak ditemukan pengurus dengan data tersebut.",
                    "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dataGridViewpengurus.DataSource = hasil;
        }


        
        private void buttonTambah_Click(object? sender, EventArgs e)
        {
            string username = textBoxusername.Text.Trim();
            string password = textBoxpassword.Text.Trim();
            string nama = textBoxpengurus.Text.Trim();
            string noTelepon = textBoxnotelp.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(nama) ||
                string.IsNullOrWhiteSpace(noTelepon))
            {
                MessageBox.Show("Semua field harus diisi untuk menambahkan pengurus!",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _ctrl.TambahPengurus(username, password, nama, noTelepon);

            MessageBox.Show("Data pengurus berhasil ditambahkan.",
                "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            TampilkanSemua();
        }
    }
}
