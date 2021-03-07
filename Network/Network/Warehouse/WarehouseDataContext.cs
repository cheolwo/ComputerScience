using Microsoft.EntityFrameworkCore;
using Warehouse.Model;

namespace Warehouse
{
 public class WarehouseDbContext : DbContext
 {
   public WarehouseDbCotnext(DbContextOption option)
    :base(option)
    {}
    
   public DbSet<Warehouse> Warehouses {get; set;}
   public DbSet<WCommodity> WCommodities {get; set;}
   public DbSet<DividedCommodity> DividedCommodities {get; set;}
   public DbSet<OutgoingCommodity> OutgoingCommodities {get; set;}
   public DbSet<LoadFrame> LoadFrames {get; set;}
   public DbSet<Pack> Pakcs {get; set;}
   public DbSet<ImageofPack> ImagesofPack {get; set;}
   public DbSet<IncomingTag> IncomingTags {get; set;}
   public DbSet<DividedTag> DividedTags {get; set;}
   public DbSet<ImageofCommodity> ImagesofCommodity {get; set;}
   public DbSet<ImagesopIncoming> ImagesofIncoming {get; set;}'
   public DbSet<ImageofLoading> ImagesofLoading {get; set;}
   public DbSet<ImageofOutgoing> ImagesofOutgogin {get; set;}
   public DbSet<ImageofDelivering> ImageofDelivering {get; set;}
 }
}
