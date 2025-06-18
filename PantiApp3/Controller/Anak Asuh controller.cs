using System.Collections.Generic;
using Microsoft.VisualBasic.ApplicationServices;
using Panti_Asuhan_Role_Admin.Model;

namespace Panti_Asuhan_Role_Admin.Controller
{
    public class Anak_Asuh_controller
    {
        /* READ */
        public List<AnakAsuhModel> GetAllAnak() =>
            Anak_Asuh_model.GetAll();

        public List<AnakAsuhModel> CariAnak(string nama, string jenisKelamin,int usia) =>
            Anak_Asuh_model.Search(nama, jenisKelamin,usia);

        /* CREATE – satu method saja, mengembalikan bool */
        public bool TambahAnak(string nama, string jenisKelamin, int usia, int userId)
        {
            if (string.IsNullOrWhiteSpace(nama) ||
                string.IsNullOrWhiteSpace(jenisKelamin) ||
                usia <= 0 ||
                userId <= 0)
                return false;

            Anak_Asuh_model.Insert(nama.Trim(), jenisKelamin, usia, userId);
            return true;
        }

    }
}
