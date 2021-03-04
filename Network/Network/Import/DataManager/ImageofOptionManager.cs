﻿using Import.ImportDataContext;
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
            return await _commotityDataContext.ImageofOptions.Where(
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
            UpdateOption.ImageRoute= Image.ImageRoute;
            UpdateOption.ImageTitle = Image.ImageTitle;
            UpdateOption.Option = Image.Option;

            _commotityDataContext.ImageofOptions.Update(UpdateOption);
            _commotityDataContext.SaveChanges();
        }

        public List<ImageofOption> GetByOptionToList(Option option)
        {
            return _commotityDataContext.ImageofOptions.Where(u => u.Option.Equals(option)).ToList();
        }
    }
}
