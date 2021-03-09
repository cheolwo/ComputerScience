using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Model
{
    public class DetailofSCommodity
    {
        [Key] public int Id { get; set; } 
        
        public string Brand { get; set; }
        public string Menufactured { get; set; }
        
        [Required] public Authenticate Authenticate { get; set; }
        [Required] public Import Import { get; set; }
        [Required] public bool PossibleUnder20 { get; set; }
        [Required] public int MaximumPossibleQuantity { get; set; } // per Individual
        [Required] public int DurationTime { get; set; } // 단위 : 일
        [Required] public bool IsVAT { get; set; }

        public List<DetailImage> DetailImages { get; set; }
        public int WarehouseNo { get; set; }
        public string WarehouseCode { get; set; }

        public List<Doc> Docs { get; set; }
        public int CommodityNo { get; set; }
        public SCommodity SCommodity { get; set; }
        
        public void ImportDefaultValue(SCommodity SCommodity)
        {
            Authenticate = Authenticate.인증대상;
            Import = Import.Import;
            PossibleUnder20 = true;
            MaximumPossibleQuantity = 3;
            DurationTime = 3;
            IsVAT = true;
            
            this.SCommodity = SCommodity;
            CommodityNo = SCommodity.Id;
        }
        
        public void AgencyDefaultValue(SCommodity SCommodity)
        {
            Authenticate = Authenticate.인증대상아님;
            Import = Import.Agency;
            PossibleUnder20 = true;
            MaximumPossibleQuantity = 3;
            DurationTime = 7;
            IsVAT = false;
            
            this.SCommodity = SCommodity;
            CommodityNo = SCommodity.Id;
        }
    }

    public enum Authenticate { 인증대상 = 0, 상세페이지별도표기 = 1, 인증대상아님 = 2 }
    public enum Import { Import = 0, Agency = 1 }
}
