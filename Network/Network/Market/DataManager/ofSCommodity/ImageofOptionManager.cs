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
    public class ImageofOptionManager : IImageofOptionManager
    {
        private readonly SCommodityDataContext _commotityDataContext;

        public ImageofOptionManager(SCommodityDataContext commotityDataContext)
        {
            _commotityDataContext = commotityDataContext;
        }

        public async Task<ImageofOption> AddAsync(ImageofOption image)
        {
            _commotityDataContext.ImageofOptions.Add(image);
            await _commotityDataContext.SaveChangesAsync();

            return await _commotityDataContext.ImageofOptions.OrderByDescending(e=>e.Id).FirstOrDefaultAsync<ImageofOption>();
        }

        public ImageofOption Add(ImageofOption image)
        {
            _commotityDataContext.ImageofOptions.Add(image);
            _commotityDataContext.SaveChanges();

             return _commotityDataContext.ImageofOptions.OrderByDescending(e=>e.Id).FirstOrDefault();
        }
        
        public async Task DeleteByEntityAsync(ImageofOption imageofOption)
        {
            _commotityDataContext.ImageofOptions.Remove(imageofOption);
            await _commotityDataContext.SaveChangesAsync();
        }

        public void DeleteByEntity(ImageofOption imageofOption)
        {
            _commotityDataContext.ImageofOptions.Remove(imageofOption);
            _commotityDataContext.SaveChanges();
        }

        public async Task DeleteByIdAsync(int Id)
        {
            ImageofOption ImageofOption = await GetByIdAsync(Id);
            _commotityDataContext.ImageofOptions.Remove(ImageofOption);
            await _commotityDataContext.SaveChangesAsync();
        }

        public void DeleteById(int Id)
        {
            ImageofOption ImageofOption = GetById(Id);
            _commotityDataContext.ImageofOptions.Remove(ImageofOption);
            _commotityDataContext.SaveChanges();
        }

        public async Task DeleteByOption(Option option)
        {
            foreach(var Image in option.Images)
            {
                _commotityDataContext.ImageofOptions.Remove(Image);
                await _commotityDataContext.SaveChangesAsync();
            }
        }
                
        public async Task<List<ImageofOption>> GetToListByOptionAsync(Option option)
        {
            return await _commotityDataContext.ImageofOptions.Where(
            e => e.Option.Equals(option)).ToListAsync();
        }
        
        public List<ImageofOption> GetToListByOption(Option option)
        {
            return _commotityDataContext.ImageofOptions.Where(
                e => e.Option.Equals(option)).ToList();
        }

        public ImageofOption GetById(int Id)
        {
            return _commotityDataContext.ImageofOptions.Find(Id);
        }

        public async Task<ImageofOption> GetByIdAsync(int Id)
        {
            return await _commotityDataContext.ImageofOptions.FindAsync(Id);
        }

        public async Task<ImageofOption> UpdateAsync(ImageofOption image)
        {
            ImageofOption UpdateOption = await GetByIdAsync(image.Id);
            UpdateOption.ImageRoute= image.ImageRoute;
            UpdateOption.ImageTitle = image.ImageTitle;
            UpdateOption.Option = image.Option;
            UpdateOption.ImagesofDetail = image.ImagesofDetail;

            _commotityDataContext.ImageofOptions.Update(UpdateOption);
            await _commotityDataContext.SaveChangesAsync();

            return UpdateOption;
        }

        public ImageofOption Update(ImageofOption image)
        {
            ImageofOption UpdateOption = GetById(image.Id);
            UpdateOption.ImageRoute= image.ImageRoute;
            UpdateOption.ImageTitle = image.ImageTitle;
            UpdateOption.Option = image.Option;
            UpdateOption.ImagesofDetail = image.ImagesofDetail;

            _commotityDataContext.ImageofOptions.Update(UpdateOption);
            _commotityDataContext.SaveChanges();

            return UpdateOption;
        }
    }
}
