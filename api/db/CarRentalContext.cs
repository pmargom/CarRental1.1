using Microsoft.EntityFrameworkCore;

namespace CarRental.api.db {

    public class CarRentalContext : DbContext
    {
        public DbSet<Car> Cars {get;set;}
        

        protected override void OnConfiguring(DbContextOptionsBuilder builder) {
            builder.UseSqlServer(@"Data Source=x.x.x.x;Initial Catalog=dbname;User ID=dbuser;Password=dbpassword");
        }
    }

}