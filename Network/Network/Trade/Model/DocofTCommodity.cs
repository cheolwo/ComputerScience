using System.ComponentModel.DataAnnotations;

namespace Trade.Model
{
    public class DocofTCommodity
    {
        [Key] public int Id { get; set; }
        public string Exies { get; set; }
    }
}