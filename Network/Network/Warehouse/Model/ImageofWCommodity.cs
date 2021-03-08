using System.ComponentModel.DataAnnotations;

namespace Warehouse.Model
{
    public class ImageofWCommodity
   {
       [Key] public int Id { get; set; }
       public string Route { get; set; }
       public string Name { get; set; }

       public WCommodity WCommodity { get; set; }
   }
}
