using System;
using System.Collections.Generic;
using Panti_Asuhan_Role_Admin.Model;
using PantiApp3.Config;

namespace Panti_Asuhan_Role_Admin.Controller
{
    public class Anak_Asuh_controller
    {
        public List<AnakAsuhModel> GetAllAnak() =>
            Anak_Asuh_model.GetAll();

        public List<AnakAsuhModel> CariAnak(string input, string tipeKriteria) =>
            Anak_Asuh_model.PerformSearch(input, tipeKriteria);

        public bool TambahAnak(string nama, string jenisKelamin, DateTime tanggalLahir, int userId)
        {
            try
            {
                Anak_Asuh_model.Insert(nama, jenisKelamin, tanggalLahir, userId);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void UpdateStatus(int idAnak, string status)
        {
            Anak_Asuh_model.UpdateStatus(idAnak, status);
        }



    }
}
