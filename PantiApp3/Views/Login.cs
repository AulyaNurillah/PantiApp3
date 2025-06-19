using Microsoft.Win32;
using PantiApp3.Config;
using PantiApp3.Controllers;
using PantiApp3.Models;
using Panti_Asuhan_Role_Admin;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PantiApp3.Views
{
    public partial class Login : Form
    {
        private AuthController authController;

        public Login()
        {
            InitializeComponent();
            authController = new AuthController();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Masukkan username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.Text = "Masukkan username";
                txtUsername.ForeColor = Color.SteelBlue;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Masukkan password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "Masukkan password";
                txtPassword.ForeColor = Color.SteelBlue;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "Masukkan username" || password == "Masukkan password" || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                lblMessage.Text = "?? Username dan password wajib diisi.";
                return;
            }

            User user = AuthController.Login(username, password);
            if (user != null)
            {
                Session.IdUser = user.IdUser;
                Session.CurrentUser = user;

                Form dashboard = null; 
                switch (user.RoleId)
                {
                    case 1:
                        dashboard = new Dashboard(user);
                        break;
                    case 2:
                        dashboard = new BendaharaDashboard(user);
                        break;
                    case 3:
                        dashboard = new DonaturDashboard(user);
                        break;
                    default:
                        MessageBox.Show("Role tidak dikenal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                dashboard.Show();
                this.Hide();
            }
            else
            {
                lblMessage.Text = "Username atau password salah.";
            }
        }


        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var reg = new Register();
            reg.FormClosed += (s, args) => this.Close();
            this.Hide();
            reg.Show();
        }
    }
}
