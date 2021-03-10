using Market.IDataManager.ofSCommodity;
using Market.Model;
using Market.Model.ofSCommodity;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;

// 목적에 맞게 만드는 게 좋다.
namespace Logistics.Pages.ofOption
{
    public partial class Get
    {        
        [Inject] IOptionManager OptionManager { get; set; }   
        [Inject] NavigationManager NavigationManager {get; set;}
        [Inject] ISCommodityManager CommodityManager { get; set; }
        [Parameter] public string CommodityNo { get; set; }
              
        public List<Option> Options = new List<Option>();
        public SCommodity Commodity = new SCommodity();
        public Option Option = new Option();
            
        public bool AddDialogIsOpen {get; set;}
        public bool DeleteDialogIsOpen {get; set;}
        public bool UpdateDialogIsOpen {get; set;}
        
        protected override void OnInitialized()
        {
            // 상품명, 카테고리, 매입경로 보이는데 사용
            Commodity = CommodityManager.GetById(Convert.ToInt32(CommodityNo));

            Option.SCommodity = Commodity;
            Options = OptionManager.GetToListByCommodity(Commodity);   

            if(Options.Count.Equals(0))
            {
                NavigationManager.NavigateTo(string.Format("/Create/Commodity/Option/{0}", CommodityNo));
            }    

            AddDialogIsOpen = false;
            DeleteDialogIsOpen = false;
            UpdateDialogIsOpen = false;
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
