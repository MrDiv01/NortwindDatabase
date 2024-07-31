namespace NortwindDatabase.Model
{
    public class Shipper : Entity<int>
    {
        public string CompanyName { get; set; }
        public string Phone { get; set; }
    }
}
