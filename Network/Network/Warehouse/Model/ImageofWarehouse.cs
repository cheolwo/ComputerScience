using System.ComponentModel.DataAnnotations;

namespace Warehouse.Model
{
    public class ImageofWarehouse
   {
       [Key] public int Id {get; set;}
       public string ImageTitle {get; set;}
       public string ImageRoute {get; set;}

       public Warehouse Warehouse {get; set;}
   }
}
