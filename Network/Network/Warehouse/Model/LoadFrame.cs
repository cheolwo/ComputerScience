using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Warehouse.Model
{
    public class LoadFrame
   {
       [Key] public int Id { get; set; }
       public string Code { get; set; }     
       public List<DividedCommodity> DividedCommodities { get; set; }
   }
}
