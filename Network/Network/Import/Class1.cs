﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Import
{
    public class Commodity
    {
        [Key] public int CommodityNo { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public List<Option> Options { get; set; }
    }

    public class Option
    {
        [Key] public int OptionNo { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public Commodity Commodity { get; set; }

        public string NormalPrice { get; set; }
        public string SalePrice { get; set; }
        public int Quantity { get; set; }
        public string SellerCodeofCommodity { get; set; }
        public string ModelNo { get; set; }
        public string CommotityBarcode { get; set; }

        /// <summary>
        /// 대표이미지
        /// </summary>
        public string ImageTitle { get; set; }
        public byte[] ImageData { get; set; }

        /// <summary>
        /// 추가이미지
        /// </summary>
        public List<Image> Images { get; set; }
    }

    public class Image
    {
        [Key] public int ImageNo { get; set; }
        public string ImageTitle { get; set; }
        public byte[] ImageData { get; set; }
    } 
}