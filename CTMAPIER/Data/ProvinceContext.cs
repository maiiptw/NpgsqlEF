using Microsoft.EntityFrameworkCore;
using CTMAPIER.Models;
namespace CTMAPIER.Data
{
    public class ProvinceContext : DbContext
    {
        private readonly IConfiguration Configuration;
        public ProvinceContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public DbSet<Province> Provinces { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(Configuration["ConnectionStrings:CTMDB"]).UseLowerCaseNamingConvention();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Province>().ToTable("province");
        }

    }
}
