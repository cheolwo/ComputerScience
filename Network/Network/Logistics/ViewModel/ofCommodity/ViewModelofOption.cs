using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Logistics.ViewModel
{
    public class RequiredModel
    {
        [Required] public string Key {get; set;}
        [Required] public string Value {get; set;}
        
    }
}