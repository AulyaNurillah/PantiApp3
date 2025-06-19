using System;
using System.Windows.Forms;
using Panti_Asuhan_Role_Admin.Controller;

namespace Panti_Asuhan_Role_Admin
{
    public partial class Anak_Asuh : Form
    {
        private readonly Anak_Asuh_controller _ctrl = new Anak_Asuh_controller();
        private readonly Form? _dashboard;

       
        public Anak_Asuh() : this(null) { }

       
        public Anak_Asuh(Form? dashboard)
        {
            InitializeComponent();
            _dashboard = dashboard;

            Load += Anak_Asuh_Load;
            buttontambahanakasuh.Click += buttonTambah_Click;
            buttoncarianakasuh.Click += btnCari_Click;
            dataGridViewanakasuh.CellValueChanged += DataGridViewanakasuh_CellValueChanged;


            buttondashboardA.Click += (s, e) =>
            {
                _dashboard?.Show();
                Close();
            };
           
        }

       
        private void Anak_Asuh_Load(object? sender, EventArgs e)
        {
            dataGridViewanakasuh.DataSource = _ctrl.GetAllAnak();
            // Hapus kolom status lama jika ada
            if (dataGridViewanakasuh.Columns.Contains("Status"))
                dataGridViewanakasuh.Columns.Remove("Status");

            // Tambah ComboBoxColumn untuk Status
            var statusCol = new DataGridViewComboBoxColumn
            {
                Name = "Status",
                HeaderText = "Status",
                DataPropertyName = "Status",
                DataSource = new string[] { "Aktif", "Diadopsi" },
                DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton
            };

            dataGridViewanakasuh.Columns.Add(statusCol);



        }


        private void btnCari_Click(object sender, EventArgs e)
        {
            string keyword = textBoxnamaanak.Text.Trim();
            string jeniskelamin = comboBoxjeniskelamin.SelectedItem?.ToString()?.ToLower() ?? "nama";

            // Contoh isi ComboBox: "nama", "jk", "usia"

            dataGridViewanakasuh.DataSource = _ctrl.CariAnak(keyword, jeniskelamin);

        }



        private void buttonTambah_Click(object? sender, EventArgs e)
        {
            string nama = textBoxnamaanak.Text.Trim();
            string jk = comboBoxjeniskelamin.SelectedItem?.ToString() ?? "";
            DateTime tanggalLahir = dateTimePickertgllahir.Value;

            int userId = 1; // Ganti dengan user login sesungguhnya

            if (string.IsNullOrWhiteSpace(nama) || string.IsNullOrWhiteSpace(jk))
            {
                MessageBox.Show("Nama dan jenis kelamin tidak boleh kosong.", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_ctrl.TambahAnak(nama, jk, tanggalLahir, userId))
            {
                MessageBox.Show("Data berhasil ditambahkan.", "Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataGridViewanakasuh.DataSource = _ctrl.GetAllAnak();
                textBoxnamaanak.Clear();
                comboBoxjeniskelamin.SelectedIndex = -1;
                dateTimePickertgllahir.Value = DateTime.Today;
            }
            else
            {
                MessageBox.Show("Gagal menambahkan data anak.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridViewanakasuh_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var grid = (DataGridView)sender;
            var column = grid.Columns[e.ColumnIndex];

            if (column.Name == "Status")
            {
                int idAnak = Convert.ToInt32(grid.Rows[e.RowIndex].Cells["Id_Anak"].Value);
                string statusBaru = grid.Rows[e.RowIndex].Cells["Status"].Value?.ToString() ?? "Aktif";

                _ctrl.UpdateStatus(idAnak, statusBaru);
            }
            dataGridViewanakasuh.DataSource = _ctrl.GetAllAnak();

        }


    }
}
