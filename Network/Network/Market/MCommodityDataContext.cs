
using Market.Model;
using Microsoft.EntityFrameworkCore;

namespace Market
{
    public class MCommodityDataContext : DbContext
    {
       public MCommodityDataContext(DbContextOptions options)
            :base(options)
        {
           
        }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<SCommodity>()
        //         .HasOne(a => a.DetailofSCommodity)
        //         .WithOne(b => b.SCommodity)
        //         .HasForeignKey<DetailofSCommodity>(b => b.CommodityNo);
        // }

        public DbSet<Market> Markets { get; set; }
        public DbSet<Coupang> Coupangs { get; set; }
        public DbSet<Ebay> Ebays { get; set; }
        public DbSet<IndependentMall> IndependentMalls { get; set; }
        public DbSet<MCommodity> MCommodities { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}