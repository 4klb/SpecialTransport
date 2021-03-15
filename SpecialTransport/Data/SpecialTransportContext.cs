
using Microsoft.EntityFrameworkCore;
using SpecialTransport.Models;


namespace SpecialTransport.Data
{
    public class SpecialTransportContext : DbContext
    {
        public SpecialTransportContext()
        {
            
        }

        DbSet<Order> Orders { get; set; }
        DbSet<Status> Statuses { get; set; }
        DbSet<Transport> Transports { get; set; }
        DbSet<TransportType> TransportTypes { get; set; }

        DbSet<User> Users { get; set; }
        DbSet<UserType> UserTypes { get; set; }
        DbSet<Role> Roles { get; set; }
        DbSet<Mark> Marks { get; set; }
        DbSet<Mark> Work { get; set; }

        //DbSet<UserOrder> UserOrders { get; set; }
        //DbSet<Recovery> Recoveries { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = SpecialTransport4; Trusted_connection = true;");
        }
    }
}
