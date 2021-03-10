using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using Market.IDataManager.ofSCommodity;
using Logistics.Service;
using Market;
using Market.Model.ofSCommodity;

namespace Logistics.Pages.ofSCommodity
{
    public partial class Delete
    {
        [Inject] ISCommodityManager CommodityManager { get; set; }
        [Inject] IDetailofSCommodityManager CommodityDetailManager { get; set; }
        [Inject] IOptionManager CommodityOptionManager { get; set; }
        [Inject] ISCommodityFileManager FileManager { get; set; }
        [Inject] IImageofOptionManager ImageofOptionManager { get; set; }
        [Inject] IImageofDetailManager ImageofDetailManager { get; set; }
        [Inject] IDocofSCommodityManager CommodityDocManager { get; set; }
        [Inject] IDetailImageManager DetailImageManager { get; set; }
        [Inject] SCommodityDataContext CommodityDataContext { get; set; }

        [Parameter] public int CommodityNo { get; set; }
        [Parameter] public bool DeleteDialogIsOpen { get; set; }
        public bool IsDetached { get; set; }

        [Parameter] public EventCallback DialogSwitch { get; set; }

        public SCommodity Commodity = new SCommodity();

        /// Commodity, Option, Detail, Doc, OptionImage, DetailImage
        
        
        protected override void OnInitialized()
        {
            DataLoad();
            OptionImageLoad(Commodity.Options);
            DocLoad(Commodity.DetailofSCommodity);

            IsDetached = false;
        }

        // 데이터 로드
        public void DataLoad()
        {
            Commodity = CommodityManager.GetById(CommodityNo);
            Commodity.Options = CommodityOptionManager.GetToListByCommodity(Commodity);
            Commodity.DetailofSCommodity = CommodityDetailManager.GetByCommodity(Commodity);
            Commodity.DetailofSCommodity.DetailImages = DetailImageManager.GetToListByCommmodityDetail(Commodity.DetailofSCommodity);
        }

        // 옵션이미지 로드
        public void OptionImageLoad(List<Option> Options)
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
        public void DocLoad(DetailofSCommodity CommodityDetail)
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
                   
                    Commodity.DetailofSCommodity.Docs = null;
                    CommodityDataContext.Remove(Commodity);
                    CommodityDataContext.SaveChanges();
                }
                else
                {
                    FileManager.DeleteCommodityImageByCommodity(Commodity);
                    FileManager.DeleteOptionImageByCommodity(Commodity);
                    FileManager.DeleteDetailImageByCommodity(Commodity);
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
