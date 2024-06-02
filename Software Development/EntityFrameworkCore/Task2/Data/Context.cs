using Microsoft.EntityFrameworkCore;
using Task2.Data.Entities;

namespace Task2.Data
{
    public class Context : DbContext
    {
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<ClientBooking> ClientBookings { get; set; }
        public DbSet<RoomBooking> RoomBookings { get; set; }

        public Context() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=GUNEVI-LAPTOP\\SQLEXPRESS;Initial Catalog=EFCore/Task2;Integrated Security=True;Encrypt=False");
        }
    }
}
