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

        public async Task<ImageofDetail> AddAsync(ImageofDetail image)
        {
            _commotityDataContext.Add(image);
            await _commotityDataContext.SaveChangesAsync();

            return _commotityDataContext.ImageofDetails.OrderByDesending(u=u.ImageNo.Equals(image.ImageNo)).FirstOrDefaultAsync<ImageofDetail>();
        }

        public ImageofDetail Add(ImageofDetail image)
        {
            _commotityDataContext.Add(image);
            _commotityDataContext.SaveChanges();

            return _commotityDataContext.ImageofDetails.OrderByDesending(u=u.ImageNo.Equals(image.ImageNo)).FirstOrDefault();
        }

        public async Task DeleteByIdAsync(int imageNo)
        {
            await _commotityDataContext.ImageofDetails.Remove(GetByIdAsync(imageNo));
            await _commotityDataContext.SaveChanges();
        }

        public void DeleteById(int imageNo)
        {
            _commotityDataContext.ImageofDetails.Remove(GetById(imageNo));
            _commotityDataContext.SaveChanges();
        }

        public async Task DeleteByEntity(ImageofDetail imageofDatail)
        {
            _commotityDataContext.ImageofDetails.Remove(imageofDatail);
            await _commotityDataContext.SaveChangesAsync();
        }

        public void DeleteByEntity(ImageofDetail imageofDatail)
        {
            _commotityDataContext.ImageofDetails.Remove(imageofDatail);
            _commotityDataContext.SaveChanges();
        }

        public List<ImageofDetail> GetToListByImageofOption(Commodity commodity)
        {
            return _commotityDataContext.ImageofDetails.Where(
                e => e.CommodityDetail.Commodity.Equals(commodity)).ToList();
        }
        
        public async Task<List<ImageofDetail>> GetToListByImageofOptionAsync(CommodityDetail commodityDetail)
        {
            return await _commotityDataContext.ImageofDetails.Where(
                e => e.CommodityDetail.Equals(commodityDetail)).ToListAsync();
        }

        public async Task<ImageofDetail> GetById(int imageNo)
        {
            return await _commotityDataContext.ImageofDetails.FindAsync(imageNo);
        }
              
        public ImageofDetail GetById(int imageNo)
        {
            return _commotityDataContext.ImageofDetails.Find(imageNo);
        }
        
        public Task<ImageofDetail> Update(ImageofDetail image)
        {
            Task<ImageofDetail> UpdateImage = await GetByIdAsync(image.ImageNo);
            UpdateImage.Result.ImageRoute = image.ImageRoute;
            UpdateImage.Result.ImageTitle = image.ImageTitle;
            UpdateImage.Result.CommodityDetail = image.CommodityDetail;

            _commotityDataContext.ImageofDetails.Update(UpdateImage);
            await _commotityDataContext.SaveChangesAsync();

            return UpdateImage;
        }

        public ImageofDetail Update(ImageofDetail image)
        {
            ImageofDetail UpdateImage = GetById(image.ImageNo);
            UpdateImage.ImageRoute = image.ImageRoute;
            UpdateImage.ImageTitle = image.ImageTitle;
            UpdateImage.CommodityDetail = image.CommodityDetail;

            _commotityDataContext.ImageofDetails.Update(UpdateImage);
            _commotityDataContext.SaveChanges();

            return ImageofDetail;
        }
    }
}
