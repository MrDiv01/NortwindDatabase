namespace NortwindDatabase.Model
{
    public class CustomerDemographic : Entity<int>
    {
        public string CustomerTypeID { get; set; }
        public string CustomerDesc { get; set; }

        public Customer Customer { get; set; }
    }
}
