using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Panti_Asuhan_Role_Admin.Model;

namespace Panti_Asuhan_Role_Admin.Controller
{
    public class Pengurus_controller
    {
       
        public List<PengurusModel> TampilSemuaPengurus() =>
            Pengurus_model.TampilSemuaPengurus();

        

     
        public List<PengurusModel> CariPengurus(string keyword) =>
            Pengurus_model.CariPengurus(keyword);

        
        public void TambahPengurus(string username, string password, string nama, string no_telepon) =>
            Pengurus_model.TambahPengurus(username, password, nama, no_telepon);

        public List<PengurusModel> PerformCariPengurus(string keyword, string kriteria) =>
        Pengurus_model.PerformSearch(keyword, kriteria);

    }
}

