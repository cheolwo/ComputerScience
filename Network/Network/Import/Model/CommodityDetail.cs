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
        
        public Authenticate Authenticate { get; set; }
        public Import Import { get; set; }

        public bool PossibleUnder20 { get; set; }
        public int MaximumPossibleQuantity { get; set; } // per Individual
        public DateTime DurationTime { get; set; }
        public bool IsVAT { get; set; }
        public string WarehouseCode { get; set; }
        public List<Doc> Docs { get; set; }
        [ForeignKey("Commotity")] public Commodity Commodity { get; set; }
    }

    public enum Authenticate { 인증대상 = 0, 상세페이지별도표기 = 1, 인증대상아님 = 2 }
    public enum Import { 병행수입 = 0, 그외 = 1 }
}
