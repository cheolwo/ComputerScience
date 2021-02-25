using Import.ImportDataContext;
using Import.Model;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.Pages.ofCommodity
{
    public partial class SimpleCreate
    {
        [Inject] CommotityDataContext CommotityDataContext { get; set; }
        public Commodity Commodity = new Commodity();

        protected override void OnInitialized()
        {

        }

        public bool DialogIsOpen { get; set; }

        public void Create()
        {
            CommotityDataContext.Commodities.Add(Commodity);
            CommotityDataContext.SaveChanges();
            DialogSwitch();
        }

        public void DialogSwitch()
        {
            DialogIsOpen = !DialogIsOpen;
        }
    }
}
