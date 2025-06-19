using Panti_Asuhan_Role_Admin.Controller;
using Panti_Asuhan_Role_Admin.Model;
using PantiApp3.Models;
using PantiApp3.Views;
using System;
using System.Windows.Forms;

namespace Panti_Asuhan_Role_Admin
{
    public partial class Dashboard : Form
    {
        private readonly Dashboard_controller _ctrl;
        private User currentUser;

        public Dashboard(User user)
        {
            InitializeComponent();
            _ctrl = new Dashboard_controller(this);
            currentUser = user;

            Load += (s, e) => dataGridView1.DataSource = Dashboard_model.TampilSemuaUser();
            // Tombol cari: gunakan teks username
            buttoncariD.Click += (s, e) =>
            {
                dataGridView1.DataSource = Dashboard_model.PerformSearch(textBoxnamaD.Text);
            };

            buttonanakasuhD.Click += (s, e) => _ctrl.NavigateToAnakAsuh();
            buttondonaturD.Click += (s, e) => _ctrl.NavigateToDonatur();
            buttonpengurusP.Click += (s, e) => _ctrl.NavigateToPengurus();
        }

        private void HandleLogout()
        {
            DialogResult result = MessageBox.Show("Yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                new Login().Show(); 
            }
        }
    }
}
