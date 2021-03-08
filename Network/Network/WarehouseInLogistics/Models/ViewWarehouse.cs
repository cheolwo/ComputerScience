namespace APIWarehouse.ViewModel
{
    public class WarehouseViewModel
   {
       public string Address { get; set; }
       public Country Country { get; set; }
       public string Code {get; set;}
       public List<IFormFile> Files {get; set;}
   }

    public class TransactionofCommodityViewMdoel
    {
        public string Purpose {get; set;}
        public string Incorterms {get; set;}
        public string NameofCommodity {get; set;}
        public int Quantity {get; set;}
        public double PriceperPiece {get; set;} 
        
        public List<IFormFile> FormFiles {get; set;}
        public string Other {get; set;}  // 거래 상대방
        public Warehouse Warehouse {get; set;} // 거래품 도착지
    }

    public class TransactionofPackingViewModel
    {
       public string NameofCommodity {get; set;}
       public double Width {get; set;}
       public double height {get; set;}
       public double length { get; set; }

       public double Weight {get; set;}     // 개당 무게

       public List<IFormFile> FormFiles {get; set;}
    }

    public class WaitingApproveCommodityViewModel
    {
       public int id {get; set;}
       public bool SellerApprove {get; set;}  
       public bool BuyerAppreve {get; set;}

       public double Width {get; set;}
       public double height {get; set;}
       public double length { get; set; }

       public double Weight {get; set;}         // 개당 무게
       public double PriceperPiece {get; set;}  // 개당 가격 

       public string NameofCommodity {get; set;}
    }

    public class AnticipatingCommodityViewMdoel
    {
        public string NameofCommodity {get; set;}
        public int Quantity {get; set;}
        public int TransactionId {get; set;}
        public string Barcode {get; set;}
    }

    public class AnticipatingCommodityDetailViewMdoel
    {
        public string NameofCommodity {get; set;}
        public int Quantity {get; set;}
        public int TransactionId {get; set;}

        List<IFormFile> FormFiles {get; set;}
    }

    // View는 어떠한 목적을 가진 일이기에
    // 목적에 맞게 ViewModel을 둘 필요가 있다.

    // 입고 업무 절차
    // 1. 상품 바코드 입력 - 입고인지단계 - 바코드가 없으면 바코드 생성
    // 2. 입고 태그 부착 - 입고인지단계 - 
    // 3. 분할 태그 부착 - 상품검수단계
    // 4. 적재 태급 부착 - 적재단계

   public class RecognizingIncomingCommodityViewModel
    {
        public string CommodityBarcode {get; set;}        
        public string CodeNameofIncomingTag {get; set;}
    }

   public class InspectingCommodityViewModel
   {       
       public int TransactionQuantity {get; set;}  // Transaction Get
       public int IncomingQuantity {get; set;}  // WCommodity Get
       public int CheckCommodity {get; set;}    // Input
       public string DiviedTagCodeName {get; set;}  // Input
   }

   public class LoadingCommodityViewModel
   {
        public string LoadFrameCode {get; set;}    // Input
        public string DividedTagCodeName {get; set;}    // Input
        public List<DividedCommodity> DividedCommodities { get; set; }
   }
}

public async Task<IActionResult> OnPostUploadAsync(List<IFormFile> files)
{
    long size = files.Sum(f => f.Length);

    foreach (var formFile in files)
    {
        if (formFile.Length > 0)
        {
            var filePath = Path.GetTempFileName();

            using (var stream = System.IO.File.Create(filePath))
            {
                await formFile.CopyToAsync(stream);
            }
        }
    }

    foreach (var formFile in files)
{
    if (formFile.Length > 0)
    {
        var filePath = Path.Combine(_config["StoredFilesPath"], 
            Path.GetRandomFileName());

        using (var stream = System.IO.File.Create(filePath))
        {
            await formFile.CopyToAsync(stream);
        }
    }
}

    // Process uploaded files
    // Don't rely on or trust the FileName property without validation.

    return Ok(new { count = files.Count, size });
}