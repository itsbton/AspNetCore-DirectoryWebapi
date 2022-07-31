using DirectoryWebApi.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace DirectoryWebApi
{
    public class DirectoryApiDbContext : DbContext
    {
        public DirectoryApiDbContext() { }
        public DirectoryApiDbContext(DbContextOptions options) : base(options) { }

        public DbSet<EsdEntity> Esds { get; set; }
        public DbSet<DistrictEntity> Districts { get; set; }
        public DbSet<SchoolEntity> Schools { get; set; }
    }
}
