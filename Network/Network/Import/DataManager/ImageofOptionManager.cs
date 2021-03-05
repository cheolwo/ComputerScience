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
            _commotityDataContext.ImageofOptions.Add(image);
            await _commotityDataContext.SaveChangesAsync();

            return await _commotityDataContext.ImageofOptions.OrderByDescending(e=>e.ImageNo).FirstOrDefaultAsync<ImageofOption>();
        }

        public ImageofOption Add(ImageofOption image)
        {
            _commotityDataContext.ImageofOptions.Add(image);
            _commotityDataContext.SaveChanges();

             return _commotityDataContext.ImageofOptions.OrderByDescending(e=>e.ImageNo).FirstOrDefault();
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

        public async Task DeleteByIdAsync(int imageNo)
        {
            ImageofOption ImageofOption = await GetByIdAsync(imageNo);
            _commotityDataContext.ImageofOptions.Remove(ImageofOption);
            await _commotityDataContext.SaveChangesAsync();
        }

        public void DeleteById(int imageNo)
        {
            ImageofOption ImageofOption = GetById(imageNo);
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

        public ImageofOption GetById(int imageNo)
        {
            return _commotityDataContext.ImageofOptions.Find(imageNo);
        }

        public async Task<ImageofOption> GetByIdAsync(int imageNo)
        {
            return await _commotityDataContext.ImageofOptions.FindAsync(imageNo);
        }

        public async Task<ImageofOption> UpdateAsync(ImageofOption image)
        {
            ImageofOption UpdateOption = await GetByIdAsync(image.ImageNo);
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
            ImageofOption UpdateOption = GetById(image.ImageNo);
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
