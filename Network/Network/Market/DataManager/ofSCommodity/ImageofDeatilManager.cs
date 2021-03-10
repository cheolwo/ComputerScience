using Market.IDataManager;
using Market.IDataManager.ofSCommodity;
using Market.Model;
using Market.Model.ofSCommodity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Market.DataManager.ofSCommodity
{
    public class ImageofDeatilManager : IImageofDetailManager
    {
        private readonly SCommodityDataContext _commotityDataContext;
        
        public ImageofDeatilManager(SCommodityDataContext commotityDataContext)
        {
            _commotityDataContext = commotityDataContext;
        }

        public async Task<ImageofDetail> AddAsync(ImageofDetail image)
        {
            _commotityDataContext.Add(image);
            await _commotityDataContext.SaveChangesAsync();

            return await _commotityDataContext.ImageofDetails.OrderByDescending(u=>u.Id.Equals(image.Id)).FirstOrDefaultAsync();
        }

        public ImageofDetail Add(ImageofDetail image)
        {
            _commotityDataContext.Add(image);
            _commotityDataContext.SaveChanges();

            return _commotityDataContext.ImageofDetails.OrderByDescending(u=> u.Id.Equals(image.Id)).FirstOrDefault();
        }

        public async Task DeleteByIdAsync(int Id)
        {
             _commotityDataContext.ImageofDetails.Remove(GetById(Id));
            await _commotityDataContext.SaveChangesAsync();
        }

        public void DeleteById(int Id)
        {
            _commotityDataContext.ImageofDetails.Remove(GetById(Id));
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
        
        public async Task<ImageofDetail> GetByIdAsync(int Id)
        {
            return await _commotityDataContext.ImageofDetails.FindAsync(Id);
        }
        
        public ImageofDetail GetById(int Id)
        {
            return _commotityDataContext.ImageofDetails.Find(Id);
        }

        public async Task<ImageofDetail> UpdateAsync(ImageofDetail image)
        {
            ImageofDetail UpdateImage = await GetByIdAsync(image.Id);
            UpdateImage.ImageRoute = image.ImageRoute;
            UpdateImage.ImageTitle = image.ImageTitle;
            UpdateImage.ImageofOption = image.ImageofOption;

            _commotityDataContext.ImageofDetails.Update(UpdateImage);
            await _commotityDataContext.SaveChangesAsync();

            return UpdateImage;
        }

        public ImageofDetail Update(ImageofDetail image)
        {
            ImageofDetail UpdateImage = GetById(image.Id);
            UpdateImage.ImageRoute = image.ImageRoute;
            UpdateImage.ImageTitle = image.ImageTitle;
            UpdateImage.ImageofOption = image.ImageofOption;

            _commotityDataContext.ImageofDetails.Update(UpdateImage);
            _commotityDataContext.SaveChanges();

            return UpdateImage;
        }
    }
}
