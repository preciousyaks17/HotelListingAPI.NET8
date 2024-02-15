using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options) { 
        }

    public DbSet<Hotel> Hotels { get; set; }


    public DbSet<Country> Countries {  get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
               new Country
               {
                   Id = 1,
                   Name = "Japan",
                   ShortName = "JP"

               },
               new Country
               {
                   Id = 2,
                   Name = "South Korea",
                   ShortName = "SK"
               },
               new Country
               {
                   Id = 3,
                   Name = "Jamaica",
                   ShortName = "JM"
               }
                );
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Manga Art Hotel",
                    Address = "Tokyo",
                    countryId = 1,
                    Rating = 4.3
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Fairfield by Marriott",
                    Address = "Seoul",
                    countryId = 3,
                    Rating = 4.4

                },
                 new Hotel
                 {
                     Id = 3,
                     Name = "Sandals Resort and Spa ",
                     Address = "Negril",
                     countryId = 2,
                     Rating = 4.5
                 }
                );
        }
    }

}
