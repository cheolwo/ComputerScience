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
        
        public string OptionNo {get; set;} 
        public bool AddDialogIsOpen {get; set;}
        public bool DeleteDialogIsOpen {get; set;}
        public bool UpdateDialogIsOpen {get; set;}
        
        public string Key {get; set;}
        public string Values {get; set;}

        public bool IsUpdateKey {get; set;}
        public bool IsUpdateValues {get; set;}
    
        protected override void OnInitialized()
        {
            // 상품명, 카테고리, 매입경로 보이는데 사용
            Commodity = CommodityManager.GetById(Convert.ToInt32(CommodityNo));
            Options = OptionManager.GetToListByCommodity(Commodity);
            
            if(Options != null)
            {
                IsUpdateKey =  false;
                IsUpdateValues = false;
                Key = Options[0].Key;
                foreach (var Option in Options)
                {
                    Option.Images = ImageofOptionManager.GetToListByOption(Option);
                    ValueFormat(Values, Option.Value);
                }
            }
            else
            { 
                IsUpdateKey = true; 
                IsUpdateValues = true;
            }
            
            DeleteDialogIsOpen = false;
            UpdateDialogIsOpen = false; 
            AddDialogIsOpen = false;
        }

        public string ValueFormat(string Values, string Value)
        {
            Values = Value + "," ;
        }

        public void SetKeyAndValue(string Key, string Values)
        {
            char[] delimeterChars = {',','/',' '};

            if(Values != null)
            {
                string[] Words = Values.Split(delimeterChars);
                foreach (var Word in Words)
                {
                    Option.Key = Key;
                    Option.Value = Word;
                    Option.Commodity =  Commodity;
                    Options.Add(Option);
                }
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
