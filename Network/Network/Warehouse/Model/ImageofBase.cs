using System.ComponentModel.DataAnnotations;

namespace Warehouse.Model
{
    public class ImageofBase
   {
       [Key] public int Id {get; set;}
       public string ImageTitle {get; set;}
       public string ImageRoute {get; set;}

       public Base Base {get; set;}
   }
}
