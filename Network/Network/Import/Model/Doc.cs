﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Import.Model
{
    public class Doc
    {
        [Key] public int DocNo { get; set; }
        public string NameofDoc { get; set; }
        public byte[] Document { get; set; }

        public CommodityDetail CommodityDetail { get; set; }
    }
}
