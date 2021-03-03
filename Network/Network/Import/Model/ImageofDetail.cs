using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Import.Model
{
    public class ImageofDetail
    {      
        [Key] public int ImageNo { get; set; }
        public string ImageTitle { get; set; }
        public string ImageRoute { get; set; }      
        
        public ImageofOption ImageofOption {get; set;}
    } 
}
