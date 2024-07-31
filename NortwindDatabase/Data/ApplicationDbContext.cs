using Microsoft.EntityFrameworkCore;
using NortwindDatabase.Model;


namespace NortwindDatabase.Data

{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Cutomers { get; set; }
        public DbSet<EmployeeTerritory> EmployeeTerritorys { get; set; }
        public DbSet<ProductSupplier> ProductSuppliers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<CustomerDemographic> CustomerDemographics { get; set; }
        public DbSet<Territory> Territorys { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Category
            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryName).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Description).HasMaxLength(500);
                entity.Property(e => e.Picture);
            });
            #endregion

            #region Customer
            modelBuilder.Entity<Customer>(entity =>
            {
                
                entity.Property(e => e.CompanyName).IsRequired().HasMaxLength(40);
                entity.Property(e => e.ContactName).HasMaxLength(30);
                entity.Property(e => e.ContactTitle).HasMaxLength(30);
                entity.Property(e => e.Address).HasMaxLength(60);
                entity.Property(e => e.City).HasMaxLength(15);
                entity.Property(e => e.Region).HasMaxLength(15);
                entity.Property(e => e.PostalCode).HasMaxLength(10);
                entity.Property(e => e.Country).HasMaxLength(15);
                entity.Property(e => e.Phone).HasMaxLength(24);
                entity.Property(e => e.Fax).HasMaxLength(24);
            });
            #endregion

            #region Employee
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.LastName).IsRequired().HasMaxLength(20);
                entity.Property(e => e.FirstName).IsRequired().HasMaxLength(10);
                entity.Property(e => e.Title).HasMaxLength(30);
                entity.Property(e => e.TitleOfCourtesy).HasMaxLength(25);
                entity.Property(e => e.BirthDate).HasColumnType("datetime");
                entity.Property(e => e.HireDate).HasColumnType("datetime");
                entity.Property(e => e.Address).HasMaxLength(60);
                entity.Property(e => e.City).HasMaxLength(15);
                entity.Property(e => e.Region).HasMaxLength(15);
                entity.Property(e => e.PostalCode).HasMaxLength(10);
                entity.Property(e => e.Country).HasMaxLength(15);
                entity.Property(e => e.HomePhone).HasMaxLength(24);
                entity.Property(e => e.Extension).HasMaxLength(4);
                entity.Property(e => e.Photo);
                entity.Property(e => e.Notes).HasMaxLength(1000);
                entity.Property(e => e.ReportsTo);
                entity.Property(e => e.PhotoPath).HasMaxLength(255);
            });
            #endregion

            #region Order
            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.CustomerID).HasMaxLength(5);
                entity.Property(e => e.EmployeeID);
                entity.Property(e => e.OrderDate).HasColumnType("datetime");
                entity.Property(e => e.RequiredDate).HasColumnType("datetime");
                entity.Property(e => e.ShippedDate).HasColumnType("datetime");
                entity.Property(e => e.ShipVia);
                entity.Property(e => e.Freight).HasColumnType("money");
                entity.Property(e => e.ShipName).HasMaxLength(40);
                entity.Property(e => e.ShipAddress).HasMaxLength(60);
                entity.Property(e => e.ShipCity).HasMaxLength(15);
                entity.Property(e => e.ShipRegion).HasMaxLength(15);
                entity.Property(e => e.ShipPostalCode).HasMaxLength(10);
                entity.Property(e => e.ShipCountry).HasMaxLength(15);
            });
            #endregion

            #region OrderDetail
            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.Property(e => e.UnitPrice).HasColumnType("money");
                entity.Property(e => e.Quantity).IsRequired();
                entity.Property(e => e.Discount).IsRequired();
            });
            #endregion

            #region Product
            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(p => p.ProductName).IsRequired().HasMaxLength(1000);
                entity.Property(p => p.CategoryID).IsRequired();
                entity.Property(p => p.QuantityPerUnit).IsRequired().HasMaxLength(1000);
                entity.Property(p => p.UnitPrice).IsRequired();
                entity.Property(p => p.UnitsInStock).IsRequired();
                entity.Property(p => p.UnitsOnOrder).IsRequired();
                entity.Property(p => p.ReorderLevel).IsRequired();
                entity.Property(p => p.Discontinued).IsRequired();
            });
            #endregion

            #region Shipper
            modelBuilder.Entity<Shipper>(entity =>
            {
                entity.Property(e => e.CompanyName).IsRequired().HasMaxLength(40);
                entity.Property(e => e.Phone).HasMaxLength(24);
            });
            #endregion

            #region Supplier
            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.Property(e => e.CompanyName).IsRequired().HasMaxLength(40);
                entity.Property(e => e.ContactName).HasMaxLength(30);
                entity.Property(e => e.ContactTitle).HasMaxLength(30);
                entity.Property(e => e.Address).HasMaxLength(60);
                entity.Property(e => e.City).HasMaxLength(15);
                entity.Property(e => e.Region).HasMaxLength(15);
                entity.Property(e => e.PostalCode).HasMaxLength(10);
                entity.Property(e => e.Country).HasMaxLength(15);
                entity.Property(e => e.Phone).HasMaxLength(24);
                entity.Property(e => e.Fax).HasMaxLength(24);
                entity.Property(e => e.HomePage).HasMaxLength(255);
            });
            #endregion

            #region Territory
            modelBuilder.Entity<Territory>(entity =>
            {
               
                entity.Property(e => e.TerritoryDescription).IsRequired().HasMaxLength(50);
                entity.Property(e => e.RegionID).IsRequired();
            });
            #endregion

            #region Region
            modelBuilder.Entity<Region>(entity =>
            {
                
                entity.Property(e => e.RegionDescription).IsRequired().HasMaxLength(50);
            });
            #endregion

            #region CustomerDemographic
            modelBuilder.Entity<CustomerDemographic>(entity =>
            {
                entity.Property(e => e.CustomerTypeID).IsRequired().HasMaxLength(10);
                entity.Property(e => e.CustomerDesc).HasMaxLength(500);
            });
            #endregion

            #region EmployeeTerritory
            modelBuilder.Entity<EmployeeTerritory>(entity =>
            {
                entity.Property(e => e.EmployeeID).IsRequired();
                entity.Property(e => e.TerritoryID).IsRequired().HasMaxLength(20);
            });
            #endregion

            #region ProductSupplier
            modelBuilder.Entity<ProductSupplier>(entity =>
            {
                entity.Property(e => e.ProductID).IsRequired();
                entity.Property(e => e.SupplierID).IsRequired();
            });
            #endregion
        }
    }
    }

    

  
