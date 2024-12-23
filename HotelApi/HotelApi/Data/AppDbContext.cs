using HotelApi.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace HotelApi.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }

        public static void SeedDatabase(AppDbContext context)
        {
            if (!context.Hotels.Any())
            {
                var jsonData = File.ReadAllText("Data/hotels.json");
                var hotels = JsonSerializer.Deserialize<List<Hotel>>(jsonData);

                if (hotels != null)
                {
                    foreach (var hotel in hotels)
                    {
                        if (hotel.rooms != null)
                        {
                            var rooms = hotel.rooms.Select(r => new Room
                            {
                                roomType = r.roomType,
                                amount = r.amount,
                                HotelId = hotel.id
                            }).ToList();

                            context.Rooms.AddRange(rooms);
                        }

                        // Elimina las habitaciones del hotel antes de agregarlo
                        hotel.rooms = null;

                        context.Hotels.Add(hotel);
                    }

                    context.SaveChanges();
                }
            }
        }
    }
}
