using Microsoft.EntityFrameworkCore;
using Trade.Model;

namespace Trade
{
    public class TCommodityDataContext : DbContext
    {
        public TCommodityDataContext(DbContextOptions options)
            : base(options)
        {

        }
       

    
      
        public DbSet<TCommodity> TCommodities { get; set; }
        public DbSet<DocofTCommodity> DocsofTCommodity { get; set; }
    }
}
