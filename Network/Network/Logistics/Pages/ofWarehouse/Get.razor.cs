namespace Logistics.Pages.ofWarehouse
{
  public partial class Get
  {
  [Inject] IWarehouseDataManager WarehouseDataManager {get; set;}
  public List<Warehouse> Warehouses = new List<Warehouse)();
  
  protected override async void OnInitializedAsync()
  {
    Warehouses = WarehouseDataManager.GetToList();
  }
  }
}
