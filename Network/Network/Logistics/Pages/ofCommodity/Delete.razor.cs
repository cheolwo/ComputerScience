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
    [Inject] ICommodityOptionManager CommodityOptionManager {get; set;
    [Inject] ICommodityFileManager CommodityFileManager { get; set; }
    
    [Property] public string CommodityNo {get; set;}
    [Property] public List<Commodity> Commodities {get; set;}
    [Property] public bool DeleteDialogIsOpen {get; set;}
    
    public Commodity Commodity {get; set;}
    
    protected override 
    
  }
}
