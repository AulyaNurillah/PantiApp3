namespace PantiApp3.Models
{
    public class Role : BaseModel
    {
        public int RoleId {  get; set; }
        public string NamaRole { get; set; }

        public override void PrintData()
        {
            Console.WriteLine($"ID: {RoleId}, Role: {NamaRole}");
        }
    }
}