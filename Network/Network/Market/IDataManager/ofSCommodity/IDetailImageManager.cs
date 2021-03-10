using Market.Model.ofSCommodity;
using System.Collections.Generic;
using System.Linq;

namespace Market.IDataManager.ofSCommodity
{
    public interface IDetailImageManager
    {
        DetailImage GetById(int Id);
        void DeleteByDetailImage(DetailImage detailImage);
        List<DetailImage> GetToList();
        List<DetailImage> GetToListByCommmodityDetail(DetailofSCommodity DetailofSCommodity);
        DetailImage Add(DetailImage detailImage);
        DetailImage Update(DetailImage detailImage);
    }

    public class DetailImageManager : IDetailImageManager
    {
        private readonly SCommodityDataContext _commodityDataContext;

        public DetailImageManager(SCommodityDataContext commotityDataContext)
        {
            _commodityDataContext = commotityDataContext;
        }

        public DetailImage Add(DetailImage detailImage)
        {
            _commodityDataContext.DetailImages.Add(detailImage);
            _commodityDataContext.SaveChanges();

            return _commodityDataContext.DetailImages.OrderByDescending(e => e.Id).FirstOrDefault();
        }

        public void DeleteByDetailImage(DetailImage detailImage)
        {
            _commodityDataContext.DetailImages.Remove(detailImage);
            _commodityDataContext.SaveChanges();
        }

        public DetailImage GetById(int Id)
        {
            return _commodityDataContext.DetailImages.Find(Id);
        }

        public List<DetailImage> GetToList()
        {
            return _commodityDataContext.DetailImages.ToList();
        }

        public List<DetailImage> GetToListByCommmodityDetail(DetailofSCommodity commodityDetail)
        {
            return _commodityDataContext.DetailImages.Where(u => u.DetailofSCommodity.Equals(commodityDetail)).ToList();
        }

        public DetailImage Update(DetailImage detailImage)
        {
            DetailImage image = GetById(detailImage.Id);
            image.ImageRoute = image.ImageRoute;
            image.ImageTitle = image.ImageTitle;
            _commodityDataContext.DetailImages.Update(detailImage);
            _commodityDataContext.SaveChanges();

            return image;

        }
    }
}
