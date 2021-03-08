using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Warehouse.Model
{
    public class Pack
   {
       [Key] public string PackName {get; set;}
       public string Material {get; set;}
       public double Width {get; set;}
       public double height {get; set;}
       public double length { get; set; }

       public List<ImageofPack> ImagesofPack {get; set;}
   }
}
