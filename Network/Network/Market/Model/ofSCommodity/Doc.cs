using System.ComponentModel.DataAnnotations;

namespace Market.Model.ofSCommodity
{
    public class Doc
    {
        [Key] public int Id { get; set; }
        public string NameofDoc { get; set; }
        public string DocRoute { get; set; }

        public DetailofSCommodity DetailofSCommodity { get; set; }
    }
}
