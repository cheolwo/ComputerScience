using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Model
{
    public class Doc
    {
        [Key] public int Id { get; set; }
        public string NameofDoc { get; set; }
        public string DocRoute { get; set; }

        public DetailofSCommodity DetailofSCommodity { get; set; }
    }
}
