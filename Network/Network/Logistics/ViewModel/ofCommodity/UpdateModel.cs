using MatBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.ViewModel.ofCommodity
{
    public class UpdateModel
    {
        public string ImageTitle { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public IMatFileUploadEntry MatFile { get; set; }
    }
}
