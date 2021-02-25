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

        public DbSet<Commodity> Commodities { get; set; }
        public DbSet<CommodityDetail> CommodityDetails { get; set; }
        public DbSet<Doc> Docs { get; set; }
        public DbSet<ImageofDetail> ImageofDetails { get; set; }
        public DbSet<ImageofOption> ImageofOptions { get; set; }
        public DbSet<Option> Options { get; set; }
    }
}
