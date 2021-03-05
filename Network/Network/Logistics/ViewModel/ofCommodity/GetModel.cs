using System.ComponentModel.DataAnnotations;

namespace Logistics.ViewModel.ofCommodity
{
    public class GetViewModel
    {
        [Required] public string Name { get; set; }
        public string Category { get; set; }
        public string Url { get; set; }
        public string ImageTitle { get; set; }
        public string ImageRoute { get; set; }
    }
}
