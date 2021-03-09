using System.ComponentModel.DataAnnotations;

namespace Market.Model
{
    public class DetailImage
    {
        [Key] public int Id { get; set; }
        public string ImageTitle { get; set; }
        public string ImageRoute { get; set; }

        public DetailofSCommodity DetailofSCommodity { get; set; }
    }
}