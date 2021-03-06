using Microsoft.EntityFrameworkCore;
using Warehouse.Model;

namespace Warehouse
{
    public class WCommodityDataContext : DbContext
    {
        public WCommodityDataContext(DbContextOptions<WCommodityDataContext> option)
         : base(option)
        { }

        public DbSet<Base> Bases { get; set; }
        public DbSet<ImageofBase> ImagesofBase { get; set; }
        public DbSet<WCommodity> WCommodities { get; set; }
        public DbSet<DividedCommodity> DividedCommodities { get; set; }
        public DbSet<OutgoingCommodity> OutgoingCommodities { get; set; }
        public DbSet<LoadFrame> LoadFrames { get; set; }
        public DbSet<Pack> Packs { get; set; }
        public DbSet<ImageofPack> ImagesofPack { get; set; }
        public DbSet<IncomingTag> IncomingTags { get; set; }
        public DbSet<DividedTag> DividedTags { get; set; }
        public DbSet<ImageofWCommodity> ImagesofWCommodity { get; set; }
        public DbSet<ImageofIncoming> ImagesofIncoming { get; set; }
        public DbSet<ImageofLoading> ImagesofLoading { get; set; }
        public DbSet<ImageofOutgoing> ImagesofOutgoing { get; set; }
        public DbSet<ImageofDelivering> ImagesofDelivering { get; set; }
    }
}
