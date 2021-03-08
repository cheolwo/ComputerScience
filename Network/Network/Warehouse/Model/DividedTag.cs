using System.ComponentModel.DataAnnotations;

namespace Warehouse.Model
{
    public class DividedTag
   {
       [Key] public int Id {get; set;}
       public string CodeName {get; set;}
       public bool Attached {get; set;}

       public IncomingTag IncomingTag {get; set;}
   }
}
