using PantiApp3.Controllers;
using PengeluaranModel = PantiApp3.Models.Pengeluaran;

namespace PantiApp3.Views
{
    public partial class InputPengeluaran : UserControl
    {
        private readonly PengeluaranController controller = new PengeluaranController();
        private readonly PengeluaranModel existingData;

        public event Action OnDataSaved;

        public InputPengeluaran(PengeluaranModel data = null)
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

        private TextBox txtCatatan;
        private TextBox txtJumlah;
        private TextBox txtIdUser;
        private DateTimePicker dtTanggal;
        private Button btnSimpan;

        private void InitializeComponent()
        {
            txtCatatan = new TextBox();
            txtJumlah = new TextBox();
            txtIdUser = new TextBox();
            dtTanggal = new DateTimePicker();
            btnSimpan = new Button();

            Label lblCatatan = new Label { Text = "Catatan", Location = new Point(10, 10), AutoSize = true };
            txtCatatan.Location = new Point(100, 10);
            txtCatatan.Size = new Size(200, 23);

            Label lblJumlah = new Label { Text = "Jumlah", Location = new Point(10, 45), AutoSize = true };
            txtJumlah.Location = new Point(100, 45);
            txtJumlah.Size = new Size(200, 23);

            Label lblTanggal = new Label { Text = "Tanggal", Location = new Point(10, 80), AutoSize = true };
            dtTanggal.Location = new Point(100, 80);
            dtTanggal.Size = new Size(200, 23);

            btnSimpan.Text = "Simpan";
            btnSimpan.Location = new Point(100, 160);
            btnSimpan.Size = new Size(100, 30);
            btnSimpan.Click += btnSimpan_Click;
            // 
            // InputPengeluaran
            // 
            Controls.Add(lblCatatan);
            Controls.Add(txtCatatan);
            Controls.Add(lblJumlah);
            Controls.Add(txtJumlah);
            Controls.Add(lblTanggal);
            Controls.Add(dtTanggal);
            Controls.Add(btnSimpan);
            Name = "InputPengeluaran";
            Size = new Size(350, 220);
            ResumeLayout(false);
            PerformLayout();
        }


        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtJumlah.Text, out int jumlah))
            {
                MessageBox.Show("Jumlah tidak valid.");
                return;
            }

            var pengeluaran = new PengeluaranModel
            {
                Catatan = txtCatatan.Text,
                Jumlah = jumlah,
                Tanggal = dtTanggal.Value,
            };

            if (existingData == null)
                controller.Insert(pengeluaran);
            else
            {
                pengeluaran.IdPengeluaran = existingData.IdPengeluaran;
                controller.Update(pengeluaran);
            }

            MessageBox.Show("✅ Data berhasil disimpan.");
            OnDataSaved?.Invoke();
        }
    }
}
