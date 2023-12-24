using Entities.Concrete;
using Framework.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Concrete.EntityFramework.Contexts
{
    public class MiniStadiumRentDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlite("Data source=booking.db");
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=BookingApp;Trusted_Connection=true");
        }
        public DbSet<Center> Centers { get; set; }
        public DbSet<Stadium> Stadiums { get; set;}
        public DbSet<Rent> Rents { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperation> UserOperations { get; set; }
    }
}
