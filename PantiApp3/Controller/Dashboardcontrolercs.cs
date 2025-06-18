using System.Windows.Forms;

namespace Panti_Asuhan_Role_Admin.Controller
{
    public class Dashboard_controller
    {
        private readonly Form _dashboardForm;

        public Dashboard_controller(Form dashboardForm)
        {
            _dashboardForm = dashboardForm;
        }

        public void NavigateToAnakAsuh()
        {
            var f = new Anak_Asuh(_dashboardForm);
            f.FormClosed += (s, e) => _dashboardForm.Show();
            f.Show();
            _dashboardForm.Hide();
        }

        public void NavigateToDonatur()
        {
            var f = new Donatur(_dashboardForm);
            f.FormClosed += (s, e) => _dashboardForm.Show();
            f.Show();
            _dashboardForm.Hide();
        }

        public void NavigateToPengurus()
        {
            var f = new Pengurus(_dashboardForm);
            f.FormClosed += (s, e) => _dashboardForm.Show();
            f.Show();
            _dashboardForm.Hide();
        }
    }
}
