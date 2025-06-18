using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Panti_Asuhan_Role_Admin.Model;

namespace Panti_Asuhan_Role_Admin.Controller
{
    public class Pengurus_controller
    {
        public List<PengurusModel> TampilSemuaPengurus() =>
            Pengurus_model.TampilSemuaPengurus();

        public PengurusModel? CariPengurusByUsername(string username) =>
            Pengurus_model.GetByUsername(username);



    }
}
