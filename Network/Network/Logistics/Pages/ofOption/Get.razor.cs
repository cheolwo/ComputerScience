using Import.DataManager;
using Import.ImportDataContext;
using Import.Model;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.Pages.ofOption
{
    public partial class Get
    {
        [Inject] CommotityDataContext CommotityDataContext { get; set; }
        [Inject] ICommodityManager CommodityManager { get; set; }
        [Inject] IOptionManager OptionManager { get; set; }

        public List<Option> Options { get; set; }
        public Commodity CommodityByParameter { get; set; }
        public Option Option { get; set; }
        public Image Image { get; set; }

        protected override void OnInitialized()
        {
            CommodityByParameter = CommotityDataContext.Commodities.FirstOrDefault(
                u => u.CommodityNo.Equals(Convert.ToInt32(CommodityNo)));

            Options = OptionManager.GetByCommodityToList(CommodityByParameter);
        }

        public void Add()
        {
            AddDialogSwitch();
        }

        public void Delete()
        {
            DeleteDialogSwitch();
        }

        public void Update()
        {
            UpdateDialogSwitch();
        }

        [Parameter]
        public string CommodityNo { get; set; }

        public bool AddDialogIsOpen;
        public bool DeleteDialogIsOpen;
        public bool UpdateDialogIsOpen;
     
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
            UpdateDialogIsOpen = !UpdateDialogIsOpen;
        }
    }
}
