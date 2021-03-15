using Microsoft.EntityFrameworkCore;
using SpecialTransport.Models;


namespace SpecialTransport.Data
{
    public class SpecialTransportContext : DbContext
    {
        public SpecialTransportContext()
        {
            Database.Migrate();
        }

        DbSet<Order> Orders { get; set; }
        DbSet<Status> Statuses { get; set; }
        DbSet<Transport> Transports { get; set; }
        DbSet<TransportType> TransportTypes { get; set; }

        DbSet<User> Users { get; set; }
        DbSet<UserType> UserTypes { get; set; }
        DbSet<Role> Roles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = SpecialTransport; Trusted_connection = true;");
        }
    }
}
