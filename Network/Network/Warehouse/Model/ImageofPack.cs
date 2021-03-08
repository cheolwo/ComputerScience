using System.ComponentModel.DataAnnotations;

namespace Warehouse.Model
{
    public class ImageofPack
   {
       [Key] public int Id {get; set;}
       public string ImageTitie {get; set;}
       public string ImageRoute {get; set;}
   }
}
