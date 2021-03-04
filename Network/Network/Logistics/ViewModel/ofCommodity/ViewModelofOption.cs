using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using MatBlazor;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.ViewModel
{
    public class RequiredModel
    {
        [Required] public string Key {get; set;}
        [Required] public string Value {get; set;}
        
    }
}