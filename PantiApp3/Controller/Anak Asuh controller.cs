using System.Collections.Generic;
using Microsoft.VisualBasic.ApplicationServices;
using Panti_Asuhan_Role_Admin.Model;
using PantiApp3.Config;

namespace Panti_Asuhan_Role_Admin.Controller
{

    public class Anak_Asuh_controller
    {
        public List<AnakAsuhModel> GetAllAnak() =>
            Anak_Asuh_model.GetAll();

        // Ganti signature agar fleksibel dan panggil PerformSearch di Model
        public List<AnakAsuhModel> CariAnak(string input, string tipeKriteria) =>
            Anak_Asuh_model.PerformSearch(input, tipeKriteria);

        public bool TambahAnak(string nama, string jenisKelamin, int usia, int idUser)
        {
            if (string.IsNullOrWhiteSpace(nama) ||
                string.IsNullOrWhiteSpace(jenisKelamin) ||
                usia <= 0 || idUser <= 0)
                return false;

            Anak_Asuh_model.Insert(nama.Trim(), jenisKelamin, usia, idUser);
            return true;
        }
    }

}
