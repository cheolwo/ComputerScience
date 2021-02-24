using Import.ImportDataContext;
using Import.Model;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;

namespace Logistics.Pages.Commotity
{
    public partial class Get
    {
        [Inject] CommotityDataContext CommotityDataContext { get; set; }
        public List<Commodity> Commotities { get; set; }

        protected override void OnInitialized()
        {
            Commotities = CommotityDataContext.Commodities.ToList();
        }              
    }
}
