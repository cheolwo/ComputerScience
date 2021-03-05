using Import.DataManager;
using Import.Model;
using Logistics.Service;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Logistics.Pages.ofOption
{
    public partial class Create
    {
        [Inject] IOptionManager OptionManager { get; set; }
        [Inject] ICommodityManager CommodityManager { get; set; }
        [Inject] IImageofOptionManager ImageofOptionManager {get; set;}
        [Inject] ICommodityFileManager FileManager {get; set;}

        [Parameter] public string CommodityNo { get; set; }

        public Option Option = new Option();
        public ImageofOption ImageofOption = new ImageofOption();
        public List<Option> ViewOptions = new List<Option>();

        public string InputKey {get; set;}
        public string InputValues {get; set;}
        public List<string> Values {get; set;}

        protected override void OnInitialized()
        {
            Option.Commodity = CommodityManager.GetById(Convert.ToInt32(CommodityNo));         
        }

        public void SetKeyAndValue(string InputKey, string InputValues)
        {
           if(InputValues != null)
           {
               char[] delimeterChars = { ',', '/', ' ' };
               string[] Words = InputValues.Split(delimeterChars);
               foreach (var Word in Words)
               {
                   Values.Add(Word.Trim());
               }
           }        
        }

        public void AddBasedofValues(List<string> Values)
        {
            if(ViewOptions != null)
            {
                ViewOptions.Clear();
            }

            Option.Key = InputKey;
            foreach(var Value in Values)
            {
               Option.Value = Value;
               ViewOptions.Add(Option);
            }
        }

        public void OptionImageUpload(string Key, IMatFileUploadEntry[] Files)
        {
            if(Files != null)
            {
                foreach (var File in Files)
                {
                    ViewOptions.Where(e=>e.Key.Equals(Key)).FirstOrDefault().Images.Add(File);
                }
            }
        }


        public void AddAsList()
        {
            if(ViewOptions.Count > 0)
            {
                try
                {
                    
                }
                catch (System.Exception)
                {
                    
                    throw;
                }
            }
        }

        public async void Add()
        {
            bool Validate = EditContext.IsValidate();
            string Route;

            if(Validate)
            {
                try
                {
                    var AddOption = await OptionManager.AddAsync(Option);
                    if(OptionFiles != null)
                    {
                        ImageofOption.Option = AddOption;
                        foreach (var File in OptionFiles)
                        {
                            Route = await FileManager.UploadOptionImage(File);
                            ImageofOption.Name = File.Name;
                            ImageofOption.ImageRoute = Route;
                            await ImageofOptionManager.Add(ImageofOption);
                        }
                    }
                }
                catch (System.Exception)
                {     
                    throw;
                }
                finally
                {
                    Reset();
                }
            }
        }

        public void Reset()
        {
            OptionFiles.Clear();
            Option.Commodity = null;
            Option.CommotityBarcode = null;
            Option.Images = null;
            Option.ModelNo = null;
            Option.Key = null;
            Option.NormalPrice = null;
            Option.OptionNo = 0;
            Option.Quantity = 0;
            Option.SalePrice = null;
            Option.SellerCodeofCommodity = null;
            Option.Value = null;
        }
    }
}
