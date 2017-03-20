using Microsoft.EntityFrameworkCore;

namespace CarRental.api.db {

    public class CarRentalContext : DbContext
    {
        public DbSet<Car> Cars {get;set;}
        
        protected override void OnConfiguring(DbContextOptionsBuilder builder) {
            builder.UseSqlServer(@"Data Source=demosccs.database.windows.net;Initial Catalog=CarRental;User ID=demouser;Password=!ccsdemousr@2016");
        }
    }

}