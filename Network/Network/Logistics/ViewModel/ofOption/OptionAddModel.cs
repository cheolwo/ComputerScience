public class OptionAddModel
{
    [Required] public List<Option> Options {get; set;}
    [Required] public List<IMatFileUploadEntry> OptionFiles {get; set;}
    [Required] public List<IMatFileUploadEntry> DetailFiles {get; set;}
}