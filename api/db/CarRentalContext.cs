using Microsoft.EntityFrameworkCore;

namespace CarRental.api.db {

    public class CarRentalContext : DbContext
    {
        public DbSet<Car> Cars {get;set;}
        

        protected override void OnConfiguring(DbContextOptionsBuilder builder) {
            builder.UseSqlServer(@"Data Source=localhost\sqlexpress;Initial Catalog=carrental;User ID=carrentaluser;Password=123456");
        }
    }

}