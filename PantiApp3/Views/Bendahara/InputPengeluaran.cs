using Npgsql;
using PantiApp3.Config;
using PantiApp3.Controllers;
using PantiApp3.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PantiApp3.Views
{
    public partial class InputPengeluaran : UserControl
    {
        private readonly PengeluaranController controller = new PengeluaranController();
        private readonly Pengeluaran existingData;

        public event Action OnDataSaved;

        private TextBox txtCatatan;
        private TextBox txtJumlah;
        private DateTimePicker dtTanggal;
        private Button btnSimpan;

        public InputPengeluaran(Pengeluaran data = null)
        {
            existingData = data;
            InitializeComponent();

            if (existingData != null)
            {
                txtCatatan.Text = existingData.Catatan;
                txtJumlah.Text = existingData.Jumlah.ToString();
                dtTanggal.Value = existingData.Tanggal;
            }
        }

        private void InitializeComponent()
        {
            Font labelFont = new Font("Sitka Display", 11F, FontStyle.Bold);
            Font inputFont = new Font("Sitka Display", 11F);
            Font titleFont = new Font("Sitka Display", 12F, FontStyle.Bold);

            GroupBox groupBox = new GroupBox
            {
                Text = "Form Input Pengeluaran",
                Font = titleFont,
                Size = new Size(400, 230),
                Location = new Point(10, 10)
            };

            Label lblCatatan = new Label { Text = "Catatan:", Location = new Point(20, 30), Font = labelFont };
            txtCatatan = new TextBox { Location = new Point(150, 27), Size = new Size(200, 27), Font = inputFont };

            Label lblJumlah = new Label { Text = "Jumlah:", Location = new Point(20, 65), Font = labelFont };
            txtJumlah = new TextBox { Location = new Point(150, 62), Size = new Size(200, 27), Font = inputFont };

            Label lblTanggal = new Label { Text = "Tanggal:", Location = new Point(20, 100), Font = labelFont };
            dtTanggal = new DateTimePicker { Location = new Point(150, 97), Size = new Size(200, 27), Font = inputFont };

            btnSimpan = new Button
            {
                Text = "💾 Simpan",
                Font = labelFont,
                Location = new Point(150, 140),
                Size = new Size(100, 35),
                BackColor = Color.LightSalmon
            };
            btnSimpan.Click += btnSimpan_Click;

            groupBox.Controls.Add(lblCatatan);
            groupBox.Controls.Add(txtCatatan);
            groupBox.Controls.Add(lblJumlah);
            groupBox.Controls.Add(txtJumlah);
            groupBox.Controls.Add(lblTanggal);
            groupBox.Controls.Add(dtTanggal);
            groupBox.Controls.Add(btnSimpan);

            Controls.Add(groupBox);
            Size = new Size(430, 250);
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtJumlah.Text, out int jumlah))
            {
                MessageBox.Show("Jumlah tidak valid.");
                return;
            }

            int saldoSekarang = GetSaldoNow();          
            int batasMaksimal = saldoSekarang - 50_000;

            if (jumlah > batasMaksimal)
            {
                MessageBox.Show(
                    $"Saldo sekarang Rp {saldoSekarang:N0}. " +
                    $"Pengeluaran maksimum yang diizinkan adalah Rp {batasMaksimal:N0}.",
                    "Saldo Minimum",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var pengeluaran = new Pengeluaran
            {
                Catatan = txtCatatan.Text,
                Jumlah = jumlah,
                Tanggal = dtTanggal.Value
            };

            if (existingData == null)
                controller.Insert(pengeluaran);
            else
            {
                pengeluaran.IdPengeluaran = existingData.IdPengeluaran;
                controller.Update(pengeluaran);
            }

            MessageBox.Show("Data pengeluaran berhasil disimpan.");
            OnDataSaved?.Invoke();
        }
        private int GetSaldoNow()
        {
            using var conn = new NpgsqlConnection(ConnectDB.GetConnectionString());
            conn.Open();

            decimal pemasukan = (decimal)new NpgsqlCommand(
                "SELECT COALESCE(SUM(jumlah),0) FROM pemasukan", conn).ExecuteScalar();

            decimal pengeluaran = (decimal)new NpgsqlCommand(
                "SELECT COALESCE(SUM(jumlah),0) FROM pengeluaran", conn).ExecuteScalar();

            return (int)(pemasukan - pengeluaran);
        }
    }
}
