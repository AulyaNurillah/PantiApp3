using PantiApp3.Views;
using PantiApp3.Models;
using System;
using System.Windows.Forms;

namespace PantiApp3.Views
{
    public partial class KelolaKeuangan : Form
    {
        private User currentUser;

        public KelolaKeuangan(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void btnPemasukan_Click(object sender, EventArgs e)
        {
            var formPemasukan = new PemasukanView(currentUser);
            formPemasukan.ShowDialog();
        }

        private void btnPengeluaran_Click(object sender, EventArgs e)
        {
            var formPengeluaran = new PengeluaranView();
            formPengeluaran.ShowDialog();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            new BendaharaDashboard(currentUser).Show();
            this.Close();
        }
    }
}
