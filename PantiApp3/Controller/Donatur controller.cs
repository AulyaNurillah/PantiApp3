using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Panti_Asuhan_Role_Admin.Model;
using PantiApp3.Config;
using System.Collections.Generic;

namespace Panti_Asuhan_Role_Admin.Controller
{
    
    public class Donatur_controller
    {
        public List<DonaturModel> TampilSemuaDonatur() =>
            Donatur_model.TampilSemuaDonatur();

        public DonaturModel? CariDonaturByusername(string username) =>
            Donatur_model.GetByusername(username);


    }
}

