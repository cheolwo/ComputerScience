// 기획은 View 단에서 이루어질 수 있어도 실제 개발은 Model 부터 들어가기에
// 생각의 차이가 있기 마련이다. 시작과 끝이라고 비유할 수 있다.

// 창고는 입고와 출고가 있다. 그리고 상품으로 채워진다.
// 적재대, Barcode 라는 개념 또한 존재한다.

// 프로그래밍이란 행정을 원할히 하는 면이 있다.
// 그렇기에 프로그래머가 행정을 모른다면 프로그래밍의 의미가 감소하는 면이 있다.


namespace Warehouse.Model
{
  public class Warehouse
  {
    [Key] public int WarehouseNo {get; set;}
    public string Address {get; set;}
    public Country Coutry {get; set;}
    
    public List<Commodity> Commodities {get; set;}
  }
  
  enum Country {Korea = 1, China = 2, Japan = 3, Russia = 4, America = 5}
  
  // Load 기획 필요
  
  public class Commodity
  {
  [Key] public int CommodityNo {get; set;}
  public string Name {get; set;}
  public StateofIncoming StateofIncoming {get; set;}
  public DateTime IncomingTime {get; set;}
  public DateTime InspectingTime {get; set;}
  public DateTime LoadingTime {get; set;}
  
  public int Quantity {get; set;}
  
  public List<ImageofCommodity> ImagesofCommodity {get; set;}
  public List<ImageofLoading> ImagesofLoading {get; set;}
  public List<ImageofIncoming> ImagesofIncoming {get; set;}
  
  public Warehouse Warehouse {get; set;}
  public LoadFrame 
  }
  
  public class Barcode
  {
  [Key] pubilc int BarcodeNo {get; set;}
  public string CodeName {get; set;}
  }
  
  pubilc class LoadFrmae
  {
  [Key] public int LoadFrameNo {get; set;}
  public string Code {get; set;}
  public List<Commodity> Commodities {get; set;}
  
  
  }
  
  public class ImageofCommodity
  {
  [Key] public int ImageNo {get; set;}
  public string Route {get; set;}
  public string Name {get; set;}
  
  public Commodity Commodity {get; set;}
  }
  
  public class ImageofIncoming
  {
  [Key] public int ImageNo {get; set;}
  public string Route {get; set;}
  public string Name {get; set;}
  public DateTime DateTime {get; set;}
  
  public Commodity Commodity {get; set;}
  }
  
    public class ImageofLoading
  {
  [Key] public int ImageNo {get; set;}
  public string Route {get; set;}
  public string Name {get; set;}
  public DateTime DateTime {get; set;}
  
  public Commodity Commodity {get; set;}
  }
  
  
  // 대기, 검수, 반품, 적재
  enum StateofIncoming {Waiting = 1, Inspecting = 2, Returing = 3, Loading = 4}
}
