using Import.ImportDataContext;
using Import.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Import.DataManager
{
    public class ImageofOptionManager : IImageofOptionManager
    {
        private readonly CommotityDataContext _commotityDataContext;

        public ImageofOptionManager(CommotityDataContext commotityDataContext)
        {
            _commotityDataContext = commotityDataContext;
        }

        public void Add(ImageofOption Image)
        {
            _commotityDataContext.ImageofOptions.Add(Image);
            _commotityDataContext.SaveChanges();
        }

        public void DeleteById(int ImageNo)
        {
            _commotityDataContext.ImageofOptions.Remove(GetById(ImageNo));
        }
        
        public async Task GetByEntities(List<Option> options)
        {
            foreach(var option in options)
            {
                option.Images = await GetByOption(option);
            }
        }
        
        public async Task<List<ImageofOption>> GetByOption(Option option)
        {
            return await _commodityDataContext.ImageofOptions.Where(
            e => e.Option.Equals(option)).ToListAsync();
        }
        
        public List<ImageofOption> GetByCommodityToList(Commodity commodity)
        {
            return _commotityDataContext.ImageofOptions.Where(
                e => e.Option.Commodity.Equals(commodity)).ToList();
        }

        public ImageofOption GetById(int ImageNo)
        {
            return _commotityDataContext.ImageofOptions.Find(ImageNo);
        }

        public void Update(ImageofOption Image)
        {
            ImageofOption UpdateOption = GetById(Image.ImageNo);
            UpdateOption.ImageData = Image.ImageData;
            UpdateOption.ImageTitle = Image.ImageTitle;
            UpdateOption.Option = Image.Option;

            _commotityDataContext.ImageofOptions.Update(UpdateOption);
            _commotityDataContext.SaveChanges();
        }
    }
}
