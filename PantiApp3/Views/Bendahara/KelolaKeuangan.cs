using System;
using System.Windows.Forms;

namespace PantiApp3.Views
{
    public partial class KelolaKeuangan : Form
    {
        public KelolaKeuangan()
        {
            InitializeComponent();
        }

        private void btnPemasukan_Click(object sender, EventArgs e)
        {
            var formPemasukan = new PemasukanView();
            formPemasukan.ShowDialog();
        }

        private void btnPengeluaran_Click(object sender, EventArgs e)
        {
            var formPengeluaran = new PengeluaranView();
            formPengeluaran.ShowDialog();
        }

        private void KelolaKeuangan_Load(object sender, EventArgs e)
        {

        }
    }
}
