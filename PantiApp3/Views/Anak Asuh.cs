using System;
using System.Windows.Forms;
using Panti_Asuhan_Role_Admin.Controller;

namespace Panti_Asuhan_Role_Admin
{
    public partial class Anak_Asuh : Form
    {
        private readonly Anak_Asuh_controller _ctrl = new Anak_Asuh_controller();
        private readonly Form? _dashboard;

        // ctor kosong → panggil ctor utama, _dashboard = null
        public Anak_Asuh() : this(null) { }

        // ctor utama menerima dashboard (boleh null)
        public Anak_Asuh(Form? dashboard)
        {
            InitializeComponent();
            _dashboard = dashboard;

            Load += Anak_Asuh_Load;
            buttontambahanakasuh.Click += buttonTambah_Click;
            buttoncarianakasuh.Click += buttonCari_Click;

            // Navigasi
            buttondashboardA.Click += (s, e) =>
            {
                _dashboard?.Show();
                Close();
            };
            //buttondonaturA.Click += (s, e) =>
            //{
            //    var donaturForm = new Donatur(this); // jangan lempar _dashboard
            //    donaturForm.Show();
            //    Hide(); // hide saja biar tidak muncul 2 form
            //};
        }

        /* ---------------- FORM LOAD ---------------- */
        private void Anak_Asuh_Load(object? sender, EventArgs e)
        {
            dataGridViewanakasuh.DataSource = _ctrl.GetAllAnak();
        }

        /* ---------------- TOMBOL CARI --------------- */
        private void buttonCari_Click(object? sender, EventArgs e)
        {
            string nama = textBoxnamaanak.Text.Trim();
            string jk = comboBoxjeniskelamin.Text;
            int.TryParse(textBoxusia.Text, out int usia);   // usia opsional

            dataGridViewanakasuh.DataSource = _ctrl.CariAnak(nama, jk, usia);
        }

        /* ---------------- TOMBOL TAMBAH ------------- */
        private void buttonTambah_Click(object? sender, EventArgs e)
        {
            string nama = textBoxnamaanak.Text.Trim();
            string jk = comboBoxjeniskelamin.SelectedItem?.ToString() ?? "";

            if (!int.TryParse(textBoxusia.Text, out int usia) || usia <= 0)
            {
                MessageBox.Show("Usia harus berupa angka positif.", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userId = 1;  // TODO: ganti dgn ID user login

            if (_ctrl.TambahAnak(nama, jk, usia, userId))
            {
                MessageBox.Show("Data berhasil ditambahkan.", "Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataGridViewanakasuh.DataSource = _ctrl.GetAllAnak();
                textBoxnamaanak.Clear();
                textBoxusia.Clear();
                comboBoxjeniskelamin.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Nama atau jenis kelamin tidak boleh kosong.",
                                "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
