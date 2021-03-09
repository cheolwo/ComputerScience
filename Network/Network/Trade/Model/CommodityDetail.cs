using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trade.Model
{
    public class CommodityDetail
    {
        [Key] public int CommodityDetailNo { get; set; } 
        
        public string Brand { get; set; }
        public string Menufactured { get; set; }

        public double Width { get; set; }
        public double height { get; set; }
        public double length { get; set; }
        public double Weight { get; set; } // Kg

        [Required] public Authenticate Authenticate { get; set; }
        [Required] public Clearance Clearance { get; set; }
        [Required] public int DurationTime { get; set; } // 단위 : 일
        [Required] public bool IsVAT { get; set; }

        public List<DetailImage> DetailImages { get; set; }
        public int WarehouseNo { get; set; }
        public string WarehouseCode { get; set; }

        public List<Doc> Docs { get; set; }
        public int CommodityNo { get; set; }
        public Commodity Commodity { get; set; }
        
        public void ImportDefaultValue(Commodity Commodity)
        {
            Authenticate = Authenticate.인증대상;
            Clearance = Clearance.Noraml;
        
            DurationTime = 3;
            IsVAT = true;
            
            this.Commodity = Commodity;
            CommodityNo = Commodity.CommodityNo;
        }
        
        public void AgencyDefaultValue(Commodity Commodity)
        {
            Authenticate = Authenticate.인증대상아님;
            Clearance = Clearance.Agency;
            DurationTime = 7;
            IsVAT = false;
            
            this.Commodity = Commodity;
            CommodityNo = Commodity.CommodityNo;
        }
    }

    public enum Authenticate { 인증대상 = 0, 상세페이지별도표기 = 1, 인증대상아님 = 2 }
    public enum Clearance { Noraml = 0, Agency = 1 }
}
