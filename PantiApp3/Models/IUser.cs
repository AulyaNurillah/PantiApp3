namespace PantiApp3.Models
{
    public interface IUser
    {
        string Username { get; set; }
        string Password { get; set; }
        string NoTelepon { get; set; }

        void Login();
        void Logout();
    }
}