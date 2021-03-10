using Logistics.Service;
using Market.IDataManager.ofSCommodity;
using Market.Model;
using Market.Model.ofSCommodity;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;

namespace Logistics.Pages.ofOption
{
    public partial class Delete
    {
        [Inject] IOptionManager OptionManager {get; set;}
        [Inject] ISCommodityFileManager FileManager {get; set;}
        [Inject] IImageofOptionManager ImageofOptionManager {get; set;}

        [Parameter] public List<Option> Options {get; set;}
        [Parameter] public bool DeleteDialogIsOpen {get; set;}
        [Parameter] public string OptionNo {get; set;}
        
        public Option DeleteOption = new Option();
        
        protected override void OnInitialized()
        {
            DeleteOption = OptionManager.GetById(Convert.ToInt32(OptionNo));
            DeleteOption.Images = ImageofOptionManager.GetToListByOption(DeleteOption);
            //foreach(var Image in DeleteOption.Images)
            //{
            //    Image.ImagesofDetail = ImageofDetailManager.GetToListByImageofOption(Image);
            //}
        }
        
        public void OptionDelete()
        {
            if(DeleteOption.Images != null)
            {
                try
                {
                    FileManager.DeleteOptionImageByOption(DeleteOption);
                    OptionManager.DeleteByEntity(DeleteOption);
                }
                catch (System.Exception)
                {               
                    throw;
                }
                finally
                {
                    DeleteDialogIsOpen = false;
                }
            }
         
        }
        
        public void DialogSwitch() { DeleteDialogIsOpen = !DeleteDialogIsOpen; }        
    }
}
