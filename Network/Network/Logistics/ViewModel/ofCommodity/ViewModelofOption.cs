using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Logistics.ViewModel
{
    public class ViewModelofOption
    {
        [Key] public int ViewModelNo { get; set; }
        public string Key {get; set;}
        public string Value {get; set;}
        public string Name { get; set; }
        public bool IsImages { get; set; }
    }
}