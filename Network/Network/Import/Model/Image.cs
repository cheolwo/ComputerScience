using System.ComponentModel.DataAnnotations;

namespace Import.Model
{
    public class Image
    {
        [Key] public int ImageNo { get; set; }
        public string ImageTitle { get; set; }
        public byte[] ImageData { get; set; }
        
        public string ImageTitieofDetail { get; set; }
        public byte[] ImageDataofDetail { get; set; }

        public Option Option { get; set; }
    } 
}
