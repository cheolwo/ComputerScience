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

// 목적에 맞게 만드는 게 좋다.
namespace Logistics.Pages.ofOption
{
    public partial class Get
    {        
        [Inject] IOptionManager OptionManager { get; set; }   
        [Inject] NavigationManager NavigationManager {get; set;}
        [Parameter] public string CommodityNo { get; set; }
              
        public List<Option> Options = new List<Option>();
        public Commodity Commodity = new Commodity();
        public Option Option = new Option();
            
        public bool AddDialogIsOpen {get; set;}
        public bool DeleteDialogIsOpen {get; set;}
        public bool UpdateDialogIsOpen {get; set;}
        
        protected override void OnInitialized()
        {
            // 상품명, 카테고리, 매입경로 보이는데 사용
            Commodity = CommodityManager.GetById(Convert.ToInt32(CommodityNo));
            Option.Commodity = Commodity;
            Options = OptionManager.GetToListByCommodity(Commodity);   

            if(Options == null)
            {
                NavigationManager.NavigateTo(string.Format("/Create/Commodity/Option/{0}", CommodityNo));
            }    

            AddDialogIsOpen = false;
            DeleteDialogIsOpen = false;
            UpdateDialogIsOpen = false;
        }

        // public void SetKeyAndValue(string InputKey, string InputValues)
        // {
        //    if(InputValues != null)
        //    {
        //        char[] delimeterChars = { ',', '/', ' ' };
        //        string[] Words = InputValues.Split(delimeterChars);
        //        foreach (var Word in Words)
        //        {
        //            Values.Add(Word.Trim());
        //        }
        //    }        
        // }

        // public void AddBasedofValues(List<string> Values)
        // {
        //     if(ViewOptions != null)
        //     {
        //         ViewOptions.Clear();
        //     }

        //     Option.Key = InputKey;
        //     foreach(var Value in Values)
        //     {
        //        Option.Value = Value;
        //        ViewOptions.Add(Option);
        //     }
        // }

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
