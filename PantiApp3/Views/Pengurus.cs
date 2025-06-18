using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Panti_Asuhan_Role_Admin.Controller;
using Panti_Asuhan_Role_Admin.Model;

namespace Panti_Asuhan_Role_Admin
{
    public partial class Pengurus : Form
    {
        private readonly Pengurus_controller _ctrl = new Pengurus_controller();
        private readonly Form? _dashboard;

       
        public Pengurus() : this(null) { }
        
        public Pengurus(Form? dashboard)
        {
            InitializeComponent();
            _dashboard = dashboard;

            Load += Pengurus_Load;
            buttoncariP.Click += buttonCari_Click;

           
            buttondashboardP.Click += (s, e) =>
            {
                _dashboard?.Show();
                Close();
            };
            
        }

         private void Pengurus_Load(object? sender, EventArgs e)
        {
            dataGridViewpengurus.DataSource = _ctrl.TampilSemuaPengurus();
        }

    
        private void buttonCari_Click(object? sender, EventArgs e)
        {
            string username = textBoxpengurus.Text.Trim();   

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Masukkan username untuk pencarian.", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var pengu = _ctrl.CariPengurusByUsername(username);      

            dataGridViewpengurus.DataSource = pengu != null
                ? new List<PengurusModel> { pengu }
                : null;

            if (pengu == null)
                MessageBox.Show("Pengurus dengan username itu tidak ditemukan.");
        }

    }
}
