using NortwindDatabase.Model;

namespace NortwindDatabase.Model
{
    public class Category:Entity<int>
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
    }
}
