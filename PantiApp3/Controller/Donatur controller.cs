using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Panti_Asuhan_Role_Admin.Model;
using Panti_Asuhan_Role_Admin.Config;
using System.Collections.Generic;

namespace Panti_Asuhan_Role_Admin.Controller
{
    //internal class Donatur_controller
    //{
    //    private Donatur_model model = new Donatur_model();

    //    public List<Panti_Asuhan_Role_Admin.Model.Donatur> TampilSemuaDonatur()
    //    {
    //        return model.GetAllDonatur();
    //    }

    //    public Panti_Asuhan_Role_Admin.Model.Donatur CariDonaturById(int id)
    //    {
    //        return Donatur_model.GetDonaturById(id);
    //    }
    //}
    public class Donatur_controller
    {
        public List<DonaturModel> TampilSemuaDonatur() =>
            Donatur_model.TampilSemuaDonatur();

        public DonaturModel? CariDonaturByusername(string username) =>
            Donatur_model.GetByusername(username);


    }
}

