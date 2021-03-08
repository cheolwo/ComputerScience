using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Warehouse.Model
{
    public class DividedCommodity
    {
       [Key] public int Id { get; set; }
       public string TagfDividing { get; set; }
       public int Quantity { get; set; }

       public LoadFrame LoadFrmae { get; set; }
       public WCommodity WCommodity { get; set; }
       public List<ImageofLoading> ImagesofLoading {get; set;}
   }
}
