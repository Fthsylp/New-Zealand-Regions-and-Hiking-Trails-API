using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Data
{
    public class NZWalksDbContext : DbContext
    {
        public NZWalksDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data for Difficulties
            // Easy, Medium, Hard

            var difficulties = new List<Difficulty>()
            {
                new Difficulty()
                {
                    Id = Guid.Parse("ad17a6e6-b6aa-49ea-b702-279caa353bee"),
                    Name = "Easy"
                },
                new Difficulty()
                {
                    Id = Guid.Parse("572afe80-c43a-484f-9369-c1778be28617"),
                    Name = "Medium"
                },
                new Difficulty()
                {
                    Id = Guid.Parse("00cf32c4-5950-467d-8e4d-5135f5b4ea89"),
                    Name = "Hard"
                }

            };

            // Seed difficulties to the database
            modelBuilder.Entity<Difficulty>().HasData(difficulties);

            // Seed data for Regions
            var regions = new List<Region>()
            {
                new Region()
                {
                    Id = Guid.Parse("5e55c1ff-4135-4441-9e73-84ea6f9824ef"),
                    Name = "Auckland",
                    Code ="AKL",
                    RegionImageUrl = null
                },
                new Region()
                {
                    Id = Guid.Parse("3a9e8538-6563-42f6-afdb-62b8c764f755"),
                    Name = "Northland",
                    Code ="NTL",
                    RegionImageUrl = null
                },
                new Region()
                {
                    Id = Guid.Parse("1139d11e-1e3c-4add-bd54-8328d6d73127"),
                    Name = "Bay Of Plenty",
                    Code ="BOP",
                    RegionImageUrl = null
                },
                new Region()
                {
                    Id = Guid.Parse("83266d02-0593-447d-9d4d-eb61d9735945"),
                    Name = "Wellington",
                    Code ="WGN",
                    RegionImageUrl = null
                },
                new Region()
                {
                    Id = Guid.Parse("701051e9-606d-435f-81c4-ce960a223fcd"),
                    Name = "Southland",
                    Code = "STL",
                    RegionImageUrl = null
                }
            };
            modelBuilder.Entity<Region>().HasData(regions);
        }
    }
}
