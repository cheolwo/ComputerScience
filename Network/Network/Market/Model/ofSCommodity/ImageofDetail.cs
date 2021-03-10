using System.ComponentModel.DataAnnotations;

namespace Market.Model.ofSCommodity
{
    public class ImageofDetail
    {      
        [Key] public int Id { get; set; }
        public string ImageTitle { get; set; }
        public string ImageRoute { get; set; }      
        
        public ImageofOption ImageofOption {get; set;}
    } 
}
