namespace PantiApp3.Models
{
    public class User : BaseModel, IUser
    {
        public int IdUser { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string NamaUser { get; set; }
        public string NoTelepon { get; set; }
        public int RoleId { get; set; }

        public void Login()
        {
            Console.WriteLine($"User {Username} berhasil login.");
        }

        public void Logout()
        {
            Console.WriteLine($"User {Username} berhasil logout.");
        }

        public override void PrintData()
        {
            Console.WriteLine($"ID: {IdUser}, Username: {Username}, Nama: {NamaUser}, Telepon: {NoTelepon}, RoleId: {RoleId}");
        }
    }
}