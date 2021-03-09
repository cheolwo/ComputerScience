using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trade.ICommodityDataManager;
using Trade.Model;

namespace Trade.CommodityDataManager
{
    public class ImageofDeatilManager : IImageofDetailManager
    {
        private readonly CommodityDataContext _commotityDataContext;
        
        public ImageofDeatilManager(CommodityDataContext commotityDataContext)
        {
            _commotityDataContext = commotityDataContext;
        }

        public async Task<ImageofDetail> AddAsync(ImageofDetail image)
        {
            _commotityDataContext.Add(image);
            await _commotityDataContext.SaveChangesAsync();

            return await _commotityDataContext.ImageofDetails.OrderByDescending(u=>u.ImageNo.Equals(image.ImageNo)).FirstOrDefaultAsync();
        }

        public ImageofDetail Add(ImageofDetail image)
        {
            _commotityDataContext.Add(image);
            _commotityDataContext.SaveChanges();

            return _commotityDataContext.ImageofDetails.OrderByDescending(u=> u.ImageNo.Equals(image.ImageNo)).FirstOrDefault();
        }

        public async Task DeleteByIdAsync(int imageNo)
        {
             _commotityDataContext.ImageofDetails.Remove(GetById(imageNo));
            await _commotityDataContext.SaveChangesAsync();
        }

        public void DeleteById(int imageNo)
        {
            _commotityDataContext.ImageofDetails.Remove(GetById(imageNo));
            _commotityDataContext.SaveChanges();
        }

        public async Task DeleteByEntityAsync(ImageofDetail imageofDatail)
        {
            _commotityDataContext.ImageofDetails.Remove(imageofDatail);
            await _commotityDataContext.SaveChangesAsync();
        }

        public void DeleteByEntity(ImageofDetail imageofDatail)
        {
            _commotityDataContext.ImageofDetails.Remove(imageofDatail);
            _commotityDataContext.SaveChanges();
        }

        public List<ImageofDetail> GetToListByImageofOption(ImageofOption option)
        {
            return _commotityDataContext.ImageofDetails.Where(u => u.ImageofOption.Equals(option)).ToList();
        }
        
        public async Task<List<ImageofDetail>> GetToListByImageofOptionAsync(ImageofOption option)
        {
            return await _commotityDataContext.ImageofDetails.Where(u => u.ImageofOption.Equals(option)).ToListAsync();
        }
        
        public async Task<ImageofDetail> GetByIdAsync(int imageNo)
        {
            return await _commotityDataContext.ImageofDetails.FindAsync(imageNo);
        }
        
        public ImageofDetail GetById(int imageNo)
        {
            return _commotityDataContext.ImageofDetails.Find(imageNo);
        }

        public async Task<ImageofDetail> UpdateAsync(ImageofDetail image)
        {
            ImageofDetail UpdateImage = await GetByIdAsync(image.ImageNo);
            UpdateImage.ImageRoute = image.ImageRoute;
            UpdateImage.ImageTitle = image.ImageTitle;
            UpdateImage.ImageofOption = image.ImageofOption;

            _commotityDataContext.ImageofDetails.Update(UpdateImage);
            await _commotityDataContext.SaveChangesAsync();

            return UpdateImage;
        }

        public ImageofDetail Update(ImageofDetail image)
        {
            ImageofDetail UpdateImage = GetById(image.ImageNo);
            UpdateImage.ImageRoute = image.ImageRoute;
            UpdateImage.ImageTitle = image.ImageTitle;
            UpdateImage.ImageofOption = image.ImageofOption;

            _commotityDataContext.ImageofDetails.Update(UpdateImage);
            _commotityDataContext.SaveChanges();

            return UpdateImage;
        }
    }
}
