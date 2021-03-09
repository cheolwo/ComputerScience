using System.Collections.Generic;
using System.Linq;
using Trade.ICommodityDataManager;
using Trade.Model;

namespace Trade.CommodityDataManager
{
    public class CommodityDocManager : ICommodityDocManager
    {
        private readonly CommodityDataContext _CommodityDataContext;

        public CommodityDocManager(CommodityDataContext CommodityDataContext)
        {
            _CommodityDataContext = CommodityDataContext;
        }

        public Doc Add(Doc doc)
        {
            _CommodityDataContext.Docs.Add(doc);
            _CommodityDataContext.SaveChanges();

            return _CommodityDataContext.Docs.ToList().Last();
        }

        public Doc DeleteById(int DocNo)
        {
            var Doc = GetById(DocNo);
            _CommodityDataContext.Docs.Remove(Doc);
            _CommodityDataContext.SaveChanges();

            return Doc;
        }

        public List<Doc> GetByCommodityDetail(CommodityDetail CommodityDetail)
        {
            List<Doc> Docs = _CommodityDataContext.Docs.Where(e => e.CommodityDetail.Equals(CommodityDetail)).ToList();
            return Docs;
        }

        public Doc GetById(int DocNo)
        {
            return _CommodityDataContext.Docs.Find(DocNo);
        }

        public Doc Update(Doc doc)
        {
            var UpdateDoc = _CommodityDataContext.Docs.FirstOrDefault(
                e => e.DocNo.Equals(doc.DocNo));

            UpdateDoc.CommodityDetail = doc.CommodityDetail;
            UpdateDoc.DocRoute = doc.DocRoute;
            UpdateDoc.NameofDoc = doc.NameofDoc;

            _CommodityDataContext.Docs.Update(UpdateDoc);
            _CommodityDataContext.SaveChanges();

            return UpdateDoc;
        }
    }
}
