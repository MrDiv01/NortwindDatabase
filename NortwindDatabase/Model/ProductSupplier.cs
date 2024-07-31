namespace NortwindDatabase.Model
{
    public class ProductSupplier : Entity<int>
    {
        public int ProductID { get; set; }
        public int SupplierID { get; set; }

        public Product Product { get; set; }
        public Supplier Supplier { get; set; }
    }
}
