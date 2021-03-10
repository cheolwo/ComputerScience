using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Trade.Model
{
    public class TCommodity
    {
        [Key] public int Id { get; set; }

        public string NameofCommodity { get; set; }

        public string HsCode { get; set; }
        public string Category { get; set; }
        public string Url { get; set; }

        public string Incomrterms { get; set; }
        public string CodeofCrossDockingBaseForSeller { get; set; }  // 셀러 중간배송 지역 (포워더)
        public string CodeofCrossDockingBaseForBuyer { get; set; }     // 바이어 중간배송 지역 (포워더) 
        public string CodeofBuyerBase { get; set; }                     // 배송 도착지역
        public string CodeofSellerBase { get; set; }                    // 배송 시작지역

        public List<DocofTCommodity> DocofTCommodities { get; set; }
        public Group Group { get; set; }
    }
}
