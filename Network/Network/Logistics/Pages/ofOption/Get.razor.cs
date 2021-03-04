using Import.DataManager;
using Import.ImportDataContext;
using Import.Model;
using Logistics.Service;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.Pages.ofOption
{
    public partial class Get
    {        
        [Inject] IOptionManager OptionManager { get; set; }   
        [Inject] ICommodityManager CommodityManager {get; set;}       
        [Parameter] public string CommodityNo { get; set; }
              
        public List<Option> Options = new List<Option>();
        public Commodity Commodity = new Commodity();
        public Option Option = new Option();
        public OptionViewModel OptionViewModel = new OptionViewModel();
        
        public string OptionNo {get; set;} 
        public bool AddDialogIsOpen {get; set;}
        public bool DeleteDialogIsOpen {get; set;}
        public bool UpdateDialogIsOpen {get; set;}
        
        public string Key {get; set;}
        public string Values {get; set;}
        public List<OptionViewModel> OptionViewModels {get; set;}
    //     public class Option
    // {
    //     [Key] public int OptionNo { get; set; }
    //     [Required] public string Name { get; set; } // Key
    //     [Required] public string Value { get; set; }
    //     [Required] public Commodity Commodity { get; set; }
    //     [Required] public string NormalPrice { get; set; }
    //     [Required] public string SalePrice { get; set; }
    //     [Required] public int Quantity { get; set; }
    //     public string SellerCodeofCommodity { get; set; }
    //     public string ModelNo { get; set; }
    //     public string CommotityBarcode { get; set; }

    //     public List<ImageofOption> Images { get; set; }
    // }
        protected override void OnInitialized()
        {
            Commodity = CommodityManager.GetById(Convert.ToInt32(CommodityNo));
            Option.Commodity = Commodity;
            Options = OptionManager.GetToListByCommodity(Commodity);

            OptionViewModel.Name = Commodity.Name;
            
            AddDialogIsOpen = false;
            DeleteDialogIsOpen = false;
        }

        public class OptionViewModel
        {
            public string Name {get; set;}
            public string Key {get; set;}
            public string Value {get; set;}
        }

        public void SetKeyAndValue(string Key, string Values)
        {
            char[] delimeterChars = {',','/',' '}

            if(Values != null)
            {
                string[] Words = Values.Split(delimeterChars);
                foreach (var Word in Words)
                {
                    OptionViewModel.Key = Key;
                    OptionViewModel.Value = Word;
                    OptionViewModels.Add(OptionViewModel);
                }
            }
            else
            {
                OptionViewModels.Clear();
            }            
        }

        public void AddDialogSwitch()
        {
            AddDialogIsOpen = !AddDialogIsOpen;
        }

        public void DeleteDialogSwitch()
        {
            DeleteDialogIsOpen = !DeleteDialogIsOpen;
        }

        public void UpdateDialogSwitch()
        {
            UpdateDialogIsOpen = ! UpdateDialogIsOpen;
        }


    }
}
