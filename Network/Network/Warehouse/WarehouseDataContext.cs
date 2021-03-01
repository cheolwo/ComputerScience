namespace Warehouse
{
  public class WarehouseDbContext : DbContext
  {
    public WarehouseDbCotnext(DbContextOption option)
     :base(option)
     {}
    
    public DbSet<Warehouse> Warehouses {get; set;}
    public DbSet<Commodity> Commodities {get; set;}
    public DbSet<DividedCommodity> DividedCommodities {get; set;}
    public DbSet<LoadFrame> LoadFrames {get; set;}
    public DbSet<ImageofCommodity> ImagesofCommodity {get; set;}
    public DbSet<ImagesopIncoming> ImagesofIncoming {get; set;}
  }
}
