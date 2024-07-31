

namespace NortwindDatabase.Model
{
    public class Territory : Entity<int>
    {
        public string TerritoryDescription { get; set; }
        public int RegionID { get; set; }

        public Region Region { get; set; }
    }
}
