using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.Pages.ofOption
{
    public partial class Delete
    {
        [Inject] IOptionManager OptionManager {get; set;}
        [Inject] ICommodityFileManager FileManager {get; set;}
        [Inject] IImageofOptionManager ImageofOptionManager {get; set;}
        
        [Parameter] public List<Option> Options {get; set;}
        [Parameter] public bool DialogIsOpen {get; set;}
        [Parameter] public string OptionNo {get; set;}
        
        public Option DeleteOption = new Option();
        
        protected override void OnInitialized()
        {
            DeleteOption = OptionManager.GetById(OptionNo);
            DeleteOption.ImageofOptions = ImageofOptionManager.GetByOption(DeleteOption);
        }
        
        public async void OptionDelete()
        {
            try
            {
                if(DeleteOption.ImageofOptions.Count > 0)
                {
                    foreach(var Image in ImageofOptions)
                    {
                        FileManager.Delete(Image);
                    }
                }
                
                await OptionManager.Delete(DeleteOption);
                Options.Remove(DeleteOption);
                DialogSwitch();
            }
            catch(Exception e)
            {
                // Awesome.... 
            }
        }
        
        public void DialogSwitch() { DialogIsOpen = !DialogIsOpen }        
    }
}
