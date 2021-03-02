using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.Pages.ofOption
{
    public partial class Update
    {
        [Inject] IOptionManager OptionManager {get; set;}
        [Inject] ICommodityFileManager FileManager {get; set;}
        [Inject] IImageofOptionManager ImageofOptionManager {get; set;}
        
        [Parameter] public string OptionNo {get; set;}
        
        public List<IMatFileUploadEntry> Images = new List<IMatFileUploadEntry>();
        public Option UpdateOption = new Option();
            
        protected override void OnInitialized()
        {
            UpdateOption = OptionManager.GetById(Convert.ToInt32(OptionNo));
            UpdateOption.Images = ImageofOptionManager.GetByOption(UpdateOption);
        }
        
        public void FileUpload(IMatFileUploadEntry[] Files)
        {
            if (Files.Count > 0)
            {
                foreach(var File in Files)
                {
                    var Exist = Images.Find(File);
                    if(Exist == null) { Images.Add(Exist); }
                }
            }
        }
        
        public void Update()
        {
            
        }
        
        public void Reset()
        {
            // UpdateOption.... null
            
            Images.Clear();
        }
        
    }
}
