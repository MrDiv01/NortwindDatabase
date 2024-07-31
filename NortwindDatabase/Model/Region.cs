using NortwindDatabase.Model;

namespace NortwindDatabase.Model
{
    public class Region : Entity<int>
    {
        public string RegionDescription { get; set; }
    }
}
