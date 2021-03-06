using Import.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Import.ImportDataContext
{
    public class CommotityDataContext : DbContext
    {
       public CommotityDataContext(DbContextOptions options)
            :base(options)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Commodity>()
                .HasOne(a => a.CommodityDetail)
                .WithOne(b => b.Commodity)
                .HasForeignKey<CommodityDetail>(b => b.CommodityNo);
        }

        public DbSet<Commodity> Commodities { get; set; }
        public DbSet<CommodityDetail> CommodityDetails { get; set; }
        public DbSet<Doc> Docs { get; set; }
        public DbSet<ImageofDetail> ImageofDetails { get; set; }
        public DbSet<ImageofOption> ImageofOptions { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<CompanyofBuying> CompanyofBuyings { get; set; }
        public DbSet<Buying> Buyings { get; set; }
        public DbSet<DetailImage> DetailImages { get; set; }
    }
}
