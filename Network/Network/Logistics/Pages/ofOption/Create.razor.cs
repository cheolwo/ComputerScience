using Logistics.Service;
using Logistics.ViewModel;
using Market.IDataManager.ofSCommodity;
using Market.Model;
using Market.Model.ofSCommodity;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logistics.Pages.ofOption
{
    public partial class Create
    {
        [Inject] IOptionManager OptionManager { get; set; }
        [Inject] ISCommodityManager CommodityManager { get; set; }
        [Inject] IDetailofSCommodityManager CommodityDetailManager { get; set; }
        [Inject] IImageofOptionManager ImageofOptionManager {get; set;}
        [Inject] ISCommodityFileManager FileManager {get; set;}
        [Inject] IDetailImageManager DetailImageManager { get; set; }

        [Parameter] public string CommodityNo { get; set; }

        public SCommodity commodity = new SCommodity();
        public DetailofSCommodity CommodityDetail = new DetailofSCommodity();
        public DetailImage DetailImage = new DetailImage();
        public List<IMatFileUploadEntry> ImagesofDetailBuffer = new List<IMatFileUploadEntry>();

        public Option Option = new Option();
        public ImageofOption ImageofOption = new ImageofOption();
        public List<ViewModelofOption> ViewOptions = new List<ViewModelofOption>();
        
        public Dictionary<string, List<IMatFileUploadEntry>> ImagesofOptionBuffer = new Dictionary<string, List<IMatFileUploadEntry>>();

        public string InputKey {get; set;}
        public string InputValues {get; set;}
        public string CurrentValue { get; set; }
        public bool IsImages { get; set; }
        public List<string> Values = new List<string>();

        public bool ImagesofOptionDialogIsOpen { get; set; }
        public bool ImagesofDetailDialogIsOpen { get; set; }
        public EditContext EditContext { get; set; }

        protected override void OnInitialized()
        {
            commodity = CommodityManager.GetById(Convert.ToInt32(CommodityNo));
            Option.SCommodity = commodity;
            CommodityDetail = CommodityDetailManager.GetByCommodity(commodity);
            DetailImage.DetailofSCommodity = CommodityDetail;

            EditContext = new EditContext(Option);

        }

        public void SetKeyAndValue()
        {
           if(InputValues != null)
           {
               InputValues = string.Concat(InputValues.Where(c => !char.IsWhiteSpace(c)));
               char[] delimeterChars = { ',', '/'};
               string[] Words = InputValues.Split(delimeterChars);
               foreach (var Word in Words)
               {
                   Values.Add(Word);
               }
                AddBasedofValues(InputKey, Values);
           }                  
        }

        public void AddBasedofValues(string InputKey, List<string> Values)
        {
            if(ViewOptions.Count > 0)
            {
                ViewOptions.Clear();
            }

            
            foreach(var Value in Values)
            {
               ViewModelofOption viewModelofOption = new ViewModelofOption { ViewModelNo = ViewOptions.Count + 1, 
                                                                            Key = InputKey, 
                                                                            Value = Value,
                                                                            Name = commodity.Name, IsImages = false };
               ViewOptions.Add(viewModelofOption);
            }
        }

        public void ImagesofOtpionDialogSwitch(string Value)
        {
            ImagesofOptionDialogIsOpen = !ImagesofOptionDialogIsOpen;
            CurrentValue = Value;
        }

        public void ImagesofOptionUploadToBuffer(IMatFileUploadEntry[] Files)
        {      
            if (ImagesofOptionBuffer != null) 
            {
                ImagesofOptionBuffer.Clear();
            }

            if(Files != null)
            {
                foreach (var File in Files)
                {
                    ImagesofOptionBuffer[CurrentValue].Add(File);
                }            
            }
        }

        public void ImagesofDetailDialogSwitch()
        {
            ImagesofDetailDialogIsOpen = !ImagesofDetailDialogIsOpen;
        }

        public void ImagesofDetailUploadToBuffer(IMatFileUploadEntry[] Files)
        {
            if (ImagesofDetailBuffer != null)
            {
                ImagesofDetailBuffer.Clear();
            }

            if (Files != null)
            {
                foreach (var File in Files)
                {
                    ImagesofDetailBuffer.Add(File);
                }              
            }
        }

        // ViweOption, //ImagesofOptionFiles
        public async void OptionAdd()
        {
            string Route;
        
               Option.Key = InputKey;
               foreach (var Value in Values)
               {
                   Option.Value = Value;
                   Option = OptionManager.Add(Option);

                   ImageofOption.Option = Option;
                   foreach (var File in ImagesofOptionBuffer[Value])
                   {
                       Route = await FileManager.UploadOptionImage(File);
                       ImageofOption.ImageRoute = Route;
                       ImageofOption.ImageTitle = File.Name;

                       ImageofOptionManager.Add(ImageofOption);
                   }
               }        
        }

        //ImagesofDetailBuffer
        public async void DetailImageAdd()
        {
            string Route;
            foreach(var File in ImagesofDetailBuffer)
            {
                Route = await FileManager.UploadDetailImage(File);
                DetailImage.ImageRoute = Route;
                DetailImage.ImageTitle = File.Name;
                DetailImageManager.Add(DetailImage);
            }
           
        }
          
        // 적합성검사 기능이 있어야 한다.
        public void Set()
        {
            try
            {
                OptionAdd();
                DetailImageAdd();
            }
            catch
            {

            }
            finally
            {
                Reset();
            }           
        }

        //public async void Add()
        //{
        //    bool Validate = EditContext.Validate();
        //    string Route;

        //    if(Validate)
        //    {
        //        try
        //        {
        //            var AddOption = await OptionManager.AddAsync(Option);
        //            if(OptionFiles != null)
        //            {
        //                ImageofOption.Option = AddOption;
        //                foreach (var File in OptionFiles)
        //                {
        //                    Route = await FileManager.UploadOptionImage(File);
        //                    ImageofOption.Name = File.Name;
        //                    ImageofOption.ImageRoute = Route;
        //                    await ImageofOptionManager.Add(ImageofOption);
        //                }
        //            }
        //        }
        //        catch (System.Exception)
        //        {     
        //            throw;
        //        }
        //        finally
        //        {
        //            Reset();
        //        }
        //    }
        //}

        public void Reset()
        {
            // Option.CommotityBarcode = null;
            Option.Images = null;
            // Option.ModelNo = null;
            Option.Key = null;
            //  Option.NormalPrice = null;
            //  Option.Quantity = 0;
            //   Option.SalePrice = null;
            //   Option.SellerCodeofCommodity = null;
            Option.Value = null;

            InputKey = null;
            InputValues = null;
            CurrentValue = null;

            ImagesofOptionDialogIsOpen = false;
            ImagesofDetailDialogIsOpen = false;
            Values.Clear();
            ViewOptions.Clear();
            ImagesofOptionBuffer.Clear();
            ImagesofDetailBuffer.Clear();
        }
    }
}
