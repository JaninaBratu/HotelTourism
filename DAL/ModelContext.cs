using Model;
using System.Data.Entity;


namespace DAL
{
    public class ModelContext : DbContext
    {
        public ModelContext() : base("Dbconnection")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Rezervation> Rezervations { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<County> Counties { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<RezervationRoom> RezervationRooms { get; set; }
        public DbSet<FacilityRoom> FacilityRooms { get; set; }
        public DbSet<Facility> Facilities { get; set; }


    }
}
