using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Warehouse.Model
{
    public class IncomingTag
   {
       [Key] public int Id { get; set; }
       public string CodeName { get; set; }
       public bool Attached {get; set;}

       public List<DividedTag> DividedTags {get; set;}
   }
}
