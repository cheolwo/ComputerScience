using Import.ImportDataContext;
using Import.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Import.DataManager
{
    public class ImageofOptionManager : IImageofOptionManager
    {
        private readonly CommotityDataContext _commotityDataContext;

        public ImageofOptionManager(CommotityDataContext commotityDataContext)
        {
            _commotityDataContext = commotityDataContext;
        }

        public async Task<ImageofOption> AddAsync(ImageofOption image)
        {
            _commotityDataContext.ImageofOptions.Add(Image);
            await _commotityDataContext.SaveChangesAsync();

            return await _commotityDataContext.ImageofOptions.OrderByDesending(e=>e.ImageNo).FirstOrDefaultAsync<ImageofOption>();
        }

        public ImageofOption Add(ImageofOption image)
        {
            _commotityDataContext.ImageofOptions.Add(Image);
            _commotityDataContext.SaveChanges();

             return _commotityDataContext.ImageofOptions.OrderByDesending(e=>e.ImageNo).FirstOrDefault();
        }
        
        public async Task DeleteByEntityAsync(ImageofOption imageofOption)
        {
            _commotityDataContext.ImageofOptions.Remove(ImageofOption);
            await _commotityDataContext.SaveChangesAsync();
        }

        public void DeleteByEntity(ImageofOption imageofOption)
        {
            _commotityDataContext.ImageofOptions.Remove(ImageofOption);
            _commotityDataContext.SaveChanges();
        }

        public async Task DeleteByIdAsync(int imageNo)
        {
            ImageofOption ImageofOption = await GetByIdAsync(imgaeNo);
            _commotityDataContext.ImageofOptions.Remove(ImageofOption);
            await _commotityDataContext.SaveChangesAsync();
        }

        public void DeleteById(int imageNo)
        {
            ImageofOption ImageofOption = GetById(imageNo));
            _CommodityDataContext.ImageofOptions.Remove(ImageofOption);
            _CommodityDataContext.SaveChanges();
        }
                
        public async Task<List<ImageofOption>> GetToListByOptionAsync(Option option)
        {
            return await _commotityDataContext.ImageofOptions.Where(
            e => e.Option.Equals(option)).ToListAsync();
        }
        
        public List<ImageofOption> GetToListByOption(Commodity commodity)
        {
            return _commotityDataContext.ImageofOptions.Where(
                e => e.Option.Commodity.Equals(commodity)).ToList();
        }

        public ImageofOption GetById(int imageNo)
        {
            return _commotityDataContext.ImageofOptions.Find(imageNo);
        }

        public async Task<ImageofOption> GetByIdAsync(int imageNo)
        {
            return _commotityDataContext.ImageofOptions.FindAsync(imageNo);
        }

        public Task<ImageofOption> UpdateAsync(ImageofOption image)
        {
            ImageofOption UpdateOption = await GetByIdAsync(image.ImageNo);
            UpdateOption.Result.ImageRoute= image.ImageRoute;
            UpdateOption.Result.ImageTitle = image.ImageTitle;
            UpdateOption.Result.Option = image.Option;
            UpdateOption.Result.ImagesofDetail = image.ImagesofDetail;

            _commotityDataContext.ImageofOptions.Update(UpdateOption);
            await _commotityDataContext.SaveChanges();

            return UpdateOption;
        }

        public ImageofOption Update(ImageofOption image)
        {
            ImageofOption UpdateOption = GetById(image.ImageNo);
            UpdateOption.ImageRoute= image.ImageRoute;
            UpdateOpiion.ImageTitle = image.ImageTitle;
            UpdateOption.Option = image.Option;
            UpdateOption.ImagesofDetail = image.ImagesofDetail;

            _commotityDataContext.ImageofOptions.Update(UpdateOption);
            _commotityDataContext.SaveChanges();

            return UpdateOption;
        }

        public List<ImageofOption> GetByOptionToList(Option option)
        {
            return _commotityDataContext.ImageofOptions.Where(u => u.Option.Equals(option)).ToList();
        }
    }
}
