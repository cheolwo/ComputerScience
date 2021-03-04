using Import.DataManager;
using Microsoft.AspNetCore.Components;
using Logistics.Service;
using System;
using Import.Model;
using System.Collections.Generic;
using Import.ImportDataContext;

namespace Logistics.Pages.ofCommodity
{
    public partial class Delete
    {
        [Inject] ICommodityManager CommodityManager { get; set; }
        [Inject] ICommodityDetailManager CommodityDetailManager { get; set; }
        [Inject] IOptionManager CommodityOptionManager { get; set; }
        [Inject] ICommodityFileManager CommodityFileManager { get; set; }
        [Inject] IImageofOptionManager ImageofOptionManager { get; set; }
        [Inject] IImageofDetailManager ImageofDetailManager { get; set; }
        [Inject] ICommodityDocManager CommodityDocManager { get; set; }
        [Inject] CommotityDataContext CommodityDataContext { get; set; }

        [Parameter] public string CommodityNo { get; set; }
        [Parameter] public List<Commodity> Commodities { get; set; }
        [Parameter] public bool DeleteDialogIsOpen { get; set; }

        [Parameter] public EventCallback DialogSwitch { get; set; }

        public bool IsDetached { get; set; }
        public Commodity Commodity = new Commodity();

        /// Commodity, Option, Detail, Doc, OptionImage, DetailImage
        
        
        protected override void OnInitialized()
        {
            DataLoad();
            ImageLoad(Commodity.Options);
            DocLoad(Commodity.CommodityDetail);

            IsDetached = false;
        }

        // 데이터 로드
        public void DataLoad()
        {
            Commodity = CommodityManager.GetById(Convert.ToInt32(CommodityNo));
            Commodity.Options = CommodityOptionManager.GetToListByCommodity(Commodity);
            Commodity.CommodityDetail = CommodityDetailManager.GetByCommodity(Commodity);
        }

        // 이미지 로드
        public void ImageLoad(List<Option> Options)
        {
            if (Commodity.Options.Count > 0)
            {
                foreach (var Option in Options)
                {
                    Option.Images = ImageofOptionManager.GetToListByOption(Option);
                    if (Option.Images != null)
                    {
                        foreach (var ImageofOption in Option.Images)
                        {
                            ImageofOption.ImagesofDetail = ImageofDetailManager.GetToListByImageofOption(ImageofOption);
                        }
                    }
                }
            }
        }
        // 문서 로드
        public void DocLoad(CommodityDetail CommodityDetail)
        {
            CommodityDetail.Docs = CommodityDocManager.GetByCommodityDetail(CommodityDetail);
        }

        // 파일과 데이터 분리 삭제 가능
        public void DeleteDataAndFile()
        {
            try
            {
                if (IsDetached)
                {
                    foreach (var Option in Commodity.Options)
                    {
                        Option.Images = null;
                    }
                   
                    Commodity.CommodityDetail.Docs = null;
                    CommodityDataContext.Remove(Commodity);
                    CommodityDataContext.SaveChanges();
                }
                else
                {
                    CommodityDataContext.Remove(Commodity);
                    CommodityDataContext.SaveChanges();
                }
            }
            catch
            {

            }
            finally
            {
                Commodity = null;
                DeleteDialogSwitch();
            }
        }
        public void DeleteDialogSwitch()
        {
            DeleteDialogIsOpen = !DeleteDialogIsOpen;
        }
    }   
}
