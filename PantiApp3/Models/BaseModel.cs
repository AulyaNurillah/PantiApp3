namespace PantiApp3.Models
{
    public abstract class BaseModel
    {
        public int Id { get; set; }
        public abstract void PrintData();
    }
}
