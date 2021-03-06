using Import.ImportDataContext;
using Import.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Import.DataManager
{
    public interface IDetailImageManager
    {
        DetailImage GetById(int detailImageNo);
        void DeleteByDetailImage(DetailImage detailImage);
        List<DetailImage> GetToList();
        List<DetailImage> GetToListByCommmodityDetail(CommodityDetail commodityDetail);
        DetailImage Add(DetailImage detailImage);
        DetailImage Update(DetailImage detailImage);
    }

    public class DetailImageManager : IDetailImageManager
    {
        private readonly CommotityDataContext _commotityDataContext;

        public DetailImageManager(CommotityDataContext commotityDataContext)
        {
            _commotityDataContext = commotityDataContext;
        }

        public DetailImage Add(DetailImage detailImage)
        {
            _commotityDataContext.DetailImages.Add(detailImage);
            _commotityDataContext.SaveChanges();

            return _commotityDataContext.DetailImages.OrderByDescending(e => e.DetailImageNo).FirstOrDefault();
        }

        public void DeleteByDetailImage(DetailImage detailImage)
        {
            _commotityDataContext.DetailImages.Remove(detailImage);
            _commotityDataContext.SaveChanges();
        }

        public DetailImage GetById(int detailImageNo)
        {
            return _commotityDataContext.DetailImages.Find(detailImageNo);
        }

        public List<DetailImage> GetToList()
        {
            return _commotityDataContext.DetailImages.ToList();
        }

        public List<DetailImage> GetToListByCommmodityDetail(CommodityDetail commodityDetail)
        {
            return _commotityDataContext.DetailImages.Where(u => u.CommodityDetail.Equals(commodityDetail)).ToList();
        }

        public DetailImage Update(DetailImage detailImage)
        {
            DetailImage image = GetById(detailImage.DetailImageNo);
            image.ImageRoute = image.ImageRoute;
            image.ImageTitle = image.ImageTitle;
            _commotityDataContext.DetailImages.Update(detailImage);
            _commotityDataContext.SaveChanges();

            return image;

        }
    }
}
