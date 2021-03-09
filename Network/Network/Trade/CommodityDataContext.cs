using Microsoft.EntityFrameworkCore;
using System;
using Trade.Model;

namespace Trade
{
    public class TCommodityDataContext : DbContext
    {
        public CommodityDataContext(DbContextOptions options)
            : base(options)
        {

        }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<Commodity>()
        //         .HasOne(a => a.CommodityDetail)
        //         .WithOne(b => b.Commodity)
        //         .HasForeignKey<CommodityDetail>(b => b.CommodityNo);
        // }

        public DbSet<TCommodity> TCommodities { get; set; }
        public DbSet<DocofTCommodity> DocsofTCommodity { get; set; }}
    }
}
