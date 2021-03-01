namespace Logistics.Pages.ofWarehouse
{
  public partial class Manager
  {
  [Inject] IWarehouseDataManager WarehouseDataManager {get; set;}
  [Inject] IWarehouseFileManager WarehouseFileManager {get; set;}
  
  public List<Warehouse> Warehouses = new List<Warehouse>();
  
  protected override OnInitializedAsync()
  {
    
  }
  }
}
