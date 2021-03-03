using Import.DataManager;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using System.IO;
using Logistics.Service;
using System;
using System.Threading.Tasks;
using System.Linq;
using Logistics.ViewModel;
using Import.Model;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Components.Forms;

namespace Logistics.Pages.ofCommodity
{
  public partial class Delete
  {
    [Inject] ICommodityManager CommodityManager { get; set; }
    [Inject] ICommodityDetailManager CommodityDetailManager {get; set;}
    [Inject] ICommodityOptionManager CommodityOptionManager {get; set;}
    [Inject] ICommodityFileManager CommodityFileManager { get; set; }
    [Inject] IImageofOptionManager ImageofOptionManager { get; set; }
    [Inject] IImageofDetailManager ImageofDetailManager {get; set; }
    [Inject] ICommodityDocManager CommodityDocManager {get; set; }
                                                                                                                                                              
    [Property] public string CommodityNo {get; set;}
    [Property] public List<Commodity> Commodities {get; set;}
    [Property] public bool DeleteDialogIsOpen {get; set;}
    
    [Parameter] public EventCallback DialogSwitch {get; set;}
    
    public bool IsDetached {get; set;}
    public Commodity Commodity = new Commodity();
    
    /// Commodity, Option, Detail, Doc, OptionImage, DetailImage
    protected override async OnInitializedAsync()
    {  
      DataLoad();
      await ImageLoad(Commodity.Options);
      await DocLoad(Commodity.Detail);
      
      IsDetached = false;
    }
    
    // 데이터 로드
    public async void DataLoad()
    {
      Commodity = CommodityManager.GetById(Convert.ToInt32(CommodityNo));
      Commodity.Options = await CommodityOptionManager.GetByCommodityToList(Commodity);
      Commodity.CommodityDetail = await CommodityDetailManager.GetByCommodity(Commodity);
    }

    // 이미지 로드
    public async void ImageLoad(List<Option> Options)
    {
      if(Commodity.Options.Count > 0)
      {
        foreach(var Option in Options)
        {
          Option.Images = await ImageofOptionManager.GetByOptionToListI(Option);
          if(Option.Images != null)
          {
             foreach(var ImageofOption in Option.Images)
             {
               ImageofOption.ImageofDetail = await ImageofDetailManager.GetByImageofOption(ImageofOption);
             }
          }
        }
      } 
    }
    // 문서 로드
    public async void DocLoad(CommodityDetail CommodityDetail)
    {
      CommodityDetail.Docs = await CommodityDocManager.GetByCommodityDetail(CommodityDetail);
    }
    
    // 파일과 데이터 분리 삭제 가능
    public void Delete()
    {
      try
      {
        if(IsDetached)
        {
          Commodity.Options.Images = null;
          Commodity.CommodityDetail.Docs = null;
          CommodityDataContext.Remove(Commodity);
          CommodityDataContext.SaveChanges()
        }
        else
        {
          CommodityDataContext.Remove(Commodity);
          CommodityDataContext.SaveChanges()
        }      
      }
      catch(Exception e)
      {
        
      }
      finally
      {
         Commodity =  null;
         DialogSwitch.IovokAsync();
      }
    } 
  }
  
  public void DeleteDialogSwitch()
  {
    DeleteDialogSwitch =  !DeleteDialogSwitch;
  }
}
