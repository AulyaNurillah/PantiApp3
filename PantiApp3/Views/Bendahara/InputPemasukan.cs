using PantiApp3.Controllers;
using PemasukanModel = PantiApp3.Models.Pemasukan;

namespace PantiApp3.Views
{
    public partial class InputPemasukan : UserControl
    {
        private readonly PemasukanController controller = new PemasukanController();
        private readonly PemasukanModel existingData;

        public event Action OnDataSaved;

        public InputPemasukan(PemasukanModel data = null)
        {
            existingData = data;
            InitializeComponent();

            if (existingData != null)
            {
                txtCatatan.Text = existingData.Catatan;
                txtJumlah.Text = existingData.Jumlah.ToString();
                dtTanggal.Value = existingData.Tanggal;
                txtIdUser.Text = existingData.IdUser.ToString();
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

            Label lblIdUser = new Label { Text = "ID User", Location = new Point(10, 115), AutoSize = true };
            txtIdUser.Location = new Point(100, 115);
            txtIdUser.Size = new Size(200, 23);

            btnSimpan.Text = "Simpan";
            btnSimpan.Location = new Point(100, 160);
            btnSimpan.Size = new Size(100, 30);
            btnSimpan.Click += btnSimpan_Click;

            Controls.Add(lblCatatan);
            Controls.Add(txtCatatan);
            Controls.Add(lblJumlah);
            Controls.Add(txtJumlah);
            Controls.Add(lblTanggal);
            Controls.Add(dtTanggal);
            Controls.Add(lblIdUser);
            Controls.Add(txtIdUser);
            Controls.Add(btnSimpan);

            Name = "InputPemasukan";
            Size = new Size(350, 220);
        }


        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtJumlah.Text, out int jumlah))
            {
                MessageBox.Show("Jumlah tidak valid.");
                return;
            }

            if (!int.TryParse(txtIdUser.Text, out int id_user))
            {
                MessageBox.Show("ID User tidak valid.");
                return;
            }


            var pemasukan = new PemasukanModel
            {
                Catatan = txtCatatan.Text,
                Jumlah = jumlah,
                Tanggal = dtTanggal.Value,
                IdUser = id_user
            };

            if (existingData == null)
                controller.Insert(pemasukan);
            else
            {
                pemasukan.IdPemasukan = existingData.IdPemasukan;
                controller.Update(pemasukan);
            }

            MessageBox.Show("✅ Data berhasil disimpan.");
            OnDataSaved?.Invoke();
        }
    }
}
