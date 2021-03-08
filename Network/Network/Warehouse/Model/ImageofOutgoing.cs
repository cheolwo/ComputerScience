using System;
using System.ComponentModel.DataAnnotations;

namespace Warehouse.Model
{
    public class ImageofOutgoing
   {
       [Key] public int Id { get; set; }
       public string Route { get; set; }
       public string Name { get; set; }
       public DateTime DateTime { get; set; }
    
       public OutgoingCommodity OutgoingCommodity {get; set;}
   }
}
