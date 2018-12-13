using System.Data.Entity;
using NomadCars.Models;

namespace NomadCars.DAL
{
    public class NomadDbContext : DbContext
    {
        public NomadDbContext() : base("DefaultConnection")
        {
        }

        public DbSet<CarSpec> CarSpecs { get; set; }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Staff> Staff { get; set; }

        public DbSet<Person> People { get; set; }

        public DbSet<PaymentCard> PaymentCards { get; set; }

        public DbSet<CarImage> CarImages { get; set; }

        public DbSet<Purchase> Purchases { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Accessory> Accessories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}