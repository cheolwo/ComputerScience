
using Market.Model;
using Market.Model.ofSCommodity;
using Microsoft.EntityFrameworkCore;

namespace Market
{
    public class SCommodityDataContext : DbContext
    {
       public SCommodityDataContext(DbContextOptions options)
            :base(options)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SCommodity>()
                .HasOne(a => a.DetailofSCommodity)
                .WithOne(b => b.SCommodity)
                .HasForeignKey<DetailofSCommodity>(b => b.CommodityNo);
        }

        public DbSet<SCommodity> SCommodities { get; set; }
        public DbSet<DetailofSCommodity> DetailsofCommodity { get; set; }
        public DbSet<Doc> Docs { get; set; }
        public DbSet<ImageofDetail> ImageofDetails { get; set; }
        public DbSet<ImageofOption> ImageofOptions { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<DetailImage> DetailImages { get; set; }
    }
}
