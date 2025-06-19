using Microsoft.VisualBasic.ApplicationServices;
using PantiApp3.Controllers;
using PantiApp3.Views;
using System.Xml.Linq;
using AppUser = PantiApp3.Models.User;


namespace PantiApp3.Views
{
    public partial class Register : Form
    {
        private AuthController authController;
        public Register()
        {
            InitializeComponent();
            authController = new AuthController();
        }
        private void txt_Enter(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null)
            {
                if (tb.Text == "Nama lengkap" || tb.Text == "Email" || tb.Text == "Username" || tb.Text == "Password")
                {
                    tb.Text = "";
                    tb.UseSystemPasswordChar = tb.Name.Contains("Password");
                }
            }
        }
        private void txt_Leave(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null && string.IsNullOrWhiteSpace(tb.Text))
            {
                if (tb == tbName) tb.Text = "Nama lengkap";
                else if (tb == tbNoTelp) tb.Text = "Email";
                else if (tb == tbUsername) tb.Text = "Username";
                else if (tb == tbPassword) tb.Text = "Password";
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = tbName.Text.Trim();
            string noTelp = tbNoTelp.Text.Trim();
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text;

            if (string.IsNullOrWhiteSpace(name) || name == "Nama lengkap" ||
                string.IsNullOrWhiteSpace(noTelp) || noTelp == "No Telepon" ||
                string.IsNullOrWhiteSpace(username) || username == "Username" ||
                string.IsNullOrWhiteSpace(password) || password == "Password")
            {
                MessageBox.Show("Harap isi semua kolom!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = new AppUser()
            {
                NamaUser = name,
                NoTelepon = noTelp,
                Username = username,
                Password = password,
                RoleId = 3
            };

            AppUser registeredUser = authController.Register(user);

            if (registeredUser != null)
            {

                var dashboard = new DonaturDashboard(registeredUser);
                dashboard.FormClosed += (s, args) => Application.Exit();
                this.Hide();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Registrasi gagal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
    }
}
