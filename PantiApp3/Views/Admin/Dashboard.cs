using Panti_Asuhan_Role_Admin.Controller;
using Panti_Asuhan_Role_Admin.Model;

namespace Panti_Asuhan_Role_Admin
{
    public partial class Dashboard : Form
    {
        private readonly Dashboard_controller _ctrl;

        public Dashboard()
        {
            InitializeComponent();
            _ctrl = new Dashboard_controller(this);

            Load += (s, e) => dataGridView1.DataSource = Dashboard_model.TampilSemuaUser();
           
            buttoncariD.Click += (s, e) =>
            {
                dataGridView1.DataSource = Dashboard_model.PerformSearch(textBoxnamaD.Text);
            };

            buttonanakasuhD.Click += (s, e) => _ctrl.NavigateToAnakAsuh();
            buttondonaturD.Click += (s, e) => _ctrl.NavigateToDonatur();
            buttonpengurusP.Click += (s, e) => _ctrl.NavigateToPengurus();
            buttonlogout.Click += Buttonlogout_Click;
        }
        private void Buttonlogout_Click(object? sender, EventArgs e)
        {
            var result = MessageBox.Show("Yakin ingin keluar?", "Konfirmasi Keluar",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Application.Exit();          
        }
    }


}
