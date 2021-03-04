using Import.DataManager;
using Import.Model;
using Logistics.Service;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.IO;
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
            DeleteOption = OptionManager.GetById(Convert.ToInt32(OptionNo));
            DeleteOption.Images = ImageofOptionManager.GetToListByOption(DeleteOption);
        }
        
        public void OptionDelete()
        {
            try
            {
                if(DeleteOption.Images.Count > 0)
                {
                    foreach(var Image in DeleteOption.Images)
                    {
                        File.Delete(Image.ImageRoute);
                    }
                }
                
                OptionManager.DeleteByEntity(DeleteOption);
                Options.Remove(DeleteOption);
                DialogSwitch();
            }
            catch
            {
                // Awesome.... 
            }
        }
        
        public void DialogSwitch() { DialogIsOpen = !DialogIsOpen; }        
    }
}
