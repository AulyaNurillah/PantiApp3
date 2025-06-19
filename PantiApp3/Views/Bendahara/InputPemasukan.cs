using PantiApp3.Controllers;
using PantiApp3.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PantiApp3.Views
{
    public partial class InputPemasukan : UserControl
    {
        private readonly PemasukanController controller = new PemasukanController();
        private readonly Pemasukan existingData;
        private readonly User currentUser;

        public event Action OnDataSaved;

        private TextBox txtCatatan;
        private TextBox txtJumlah;
        private TextBox txtIdUser;
        private DateTimePicker dtTanggal;
        private Button btnSimpan;

        public InputPemasukan(User user)
        {
            currentUser = user;
            InitializeComponent();
            txtIdUser.Text = user.IdUser.ToString();
        }

        public InputPemasukan(Pemasukan data, User user)
        {
            existingData = data;
            txtCatatan.Text = data.Catatan;
            txtJumlah.Text = data.Jumlah.ToString();
            dtTanggal.Value = data.Tanggal;
        }

        private void InitializeComponent()
        {
            Font labelFont = new Font("Sitka Display", 11F, FontStyle.Bold);
            Font inputFont = new Font("Sitka Display", 11F);
            Font titleFont = new Font("Sitka Display", 12F, FontStyle.Bold);

            GroupBox groupBox = new GroupBox
            {
                Text = "Form Input Pemasukan",
                Font = titleFont,
                Size = new Size(400, 250),
                Location = new Point(10, 10)
            };

            Label lblCatatan = new Label { Text = "Catatan:", Location = new Point(20, 30), Font = labelFont };
            txtCatatan = new TextBox { Location = new Point(150, 27), Size = new Size(200, 27), Font = inputFont };

            Label lblJumlah = new Label { Text = "Jumlah:", Location = new Point(20, 65), Font = labelFont };
            txtJumlah = new TextBox { Location = new Point(150, 62), Size = new Size(200, 27), Font = inputFont };

            Label lblTanggal = new Label { Text = "Tanggal:", Location = new Point(20, 100), Font = labelFont };
            dtTanggal = new DateTimePicker { Location = new Point(150, 97), Size = new Size(200, 27), Font = inputFont };

            Label lblIdUser = new Label { Text = "ID User:", Location = new Point(20, 135), Font = labelFont };
            txtIdUser = new TextBox
            {
                Location = new Point(150, 132),
                Size = new Size(200, 27),
                Font = inputFont,
                ReadOnly = true
            };

            btnSimpan = new Button
            {
                Text = "💾 Simpan",
                Font = labelFont,
                Location = new Point(150, 170),
                Size = new Size(100, 35),
                BackColor = Color.LightGreen
            };
            btnSimpan.Click += btnSimpan_Click;

            groupBox.Controls.Add(lblCatatan);
            groupBox.Controls.Add(txtCatatan);
            groupBox.Controls.Add(lblJumlah);
            groupBox.Controls.Add(txtJumlah);
            groupBox.Controls.Add(lblTanggal);
            groupBox.Controls.Add(dtTanggal);
            groupBox.Controls.Add(lblIdUser);
            groupBox.Controls.Add(txtIdUser);
            groupBox.Controls.Add(btnSimpan);

            Controls.Add(groupBox);
            Size = new Size(430, 270);
        }
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtJumlah.Text, out int jumlah))
            {
                MessageBox.Show("Jumlah tidak valid.");
                return;
            }

            int id_user = currentUser.IdUser;

            var pemasukan = new Pemasukan
            {
                Catatan = txtCatatan.Text,
                Jumlah = jumlah,
                Tanggal = dtTanggal.Value,
                IdUser = id_user
            };

            if (existingData == null)
                controller.Insert(pemasukan, id_user);
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
