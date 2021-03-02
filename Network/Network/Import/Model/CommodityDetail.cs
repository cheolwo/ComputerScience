using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Import.Model
{
    public class CommodityDetail
    {
        [Key] public int CommodityDetailNo { get; set; } 
        
        public string Brand { get; set; }
        public string Menufactured { get; set; }
        
        [Required] public Authenticate Authenticate { get; set; }
        [Required] public Import Import { get; set; }

        [Required] public bool PossibleUnder20 { get; set; }
        [Required] public int MaximumPossibleQuantity { get; set; } // per Individual
        [Required] public DateTime DurationTime { get; set; }
        [Required] public bool IsVAT { get; set; }
        [Required] public string WarehouseCode { get; set; }

        public List<Doc> Docs { get; set; }

        public int CommodityNo { get; set; }
        public Commodity Commodity { get; set; }
        public List<ImageofDetail> Images { get; set; }
    }

    public enum Authenticate { 인증대상 = 0, 상세페이지별도표기 = 1, 인증대상아님 = 2 }
    public enum Import { 병행수입 = 0, 그외 = 1 }
}
