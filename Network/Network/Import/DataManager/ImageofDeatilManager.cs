using Import.ImportDataContext;
using Import.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Import.DataManager
{
    public class ImageofDeatilManager : IImageofDetailManager
    {
        private readonly CommotityDataContext _commotityDataContext;
        
        public ImageofDeatilManager(CommotityDataContext commotityDataContext)
        {
            _commotityDataContext = commotityDataContext;
        }

        public void Add(ImageofDetail Image)
        {
            _commotityDataContext.Add(Image);
            _commotityDataContext.SaveChanges();
        }

        public void DeleteById(int ImageNo)
        {
            _commotityDataContext.ImageofDetails.Remove(GetById(ImageNo));
        }

        public List<ImageofDetail> GetByCommodityToList(Commodity commodity)
        {
            return _commotityDataContext.ImageofDetails.Where(
                e => e.CommodityDetail.Commodity.Equals(commodity)).ToList();
        }

        public ImageofDetail GetById(int ImageNo)
        {
            return _commotityDataContext.ImageofDetails.Find(ImageNo);
        }

        public void Update(ImageofDetail Image)
        {
            ImageofDetail UpdateImage = GetById(Image.ImageNo);
            UpdateImage.ImageData = Image.ImageData;
            UpdateImage.ImageTitle = Image.ImageTitle;
            UpdateImage.CommodityDetail = Image.CommodityDetail;

            _commotityDataContext.ImageofDetails.Update(UpdateImage);
            _commotityDataContext.SaveChanges();
        }
    }
}
