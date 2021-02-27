using Import.ImportDataContext;
using Import.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        
        public async Task<List<ImageofDetail>> GetByEntityToList(CommodityDetail commodityDetail)
        {
            return await _commotityDataContext.ImageofDetails.Where(
                e => e.CommodityDetail.Equals(commodityDetail)).ToListAsync();
        }
        
        public async Task GetByEntity(CommodityDetail commodityDetail)
        {
            commodityDetail.Images = await GetByEntityToList(commodityDetail);
        }
        
        public ImageofDetail GetById(int ImageNo)
        {
            return _commotityDataContext.ImageofDetails.Find(ImageNo);
        }

        public void Update(ImageofDetail Image)
        {
            ImageofDetail UpdateImage = GetById(Image.ImageNo);
            UpdateImage.ImageRoute = Image.ImageRoute;
            UpdateImage.ImageTitle = Image.ImageTitle;
            UpdateImage.CommodityDetail = Image.CommodityDetail;

            _commotityDataContext.ImageofDetails.Update(UpdateImage);
            _commotityDataContext.SaveChanges();
        }
    }
}
