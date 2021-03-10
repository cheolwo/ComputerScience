
using Market.Model.ofSCommodity;
using MatBlazor;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class OptionAddModel
{
    [Required] public List<Option> Options {get; set;}
    [Required] public List<IMatFileUploadEntry> OptionFiles {get; set;}
    [Required] public List<IMatFileUploadEntry> DetailFiles {get; set;}
}