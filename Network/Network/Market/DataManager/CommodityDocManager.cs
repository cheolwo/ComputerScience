﻿using Market.IDataManager;
using Market.Model;
using System.Collections.Generic;
using System.Linq;

namespace Market.DataManager
{
    public class CommodityDocManager : ICommodityDocManager
    {
        private readonly SCommodityDataContext _CommodityDataContext;

        public CommodityDocManager(SCommodityDataContext CommodityDataContext)
        {
            _CommodityDataContext = CommodityDataContext;
        }

        public Doc Add(Doc doc)
        {
            _CommodityDataContext.Docs.Add(doc);
            _CommodityDataContext.SaveChanges();

            return _CommodityDataContext.Docs.ToList().Last();
        }

        public Doc DeleteById(int Id)
        {
            var Doc = GetById(Id);
            _CommodityDataContext.Docs.Remove(Doc);
            _CommodityDataContext.SaveChanges();

            return Doc;
        }

        public List<Doc> GetByCommodityDetail(DetailofSCommodity CommodityDetail)
        {
            List<Doc> Docs = _CommodityDataContext.Docs.Where(e => e.DetailofSCommodity.Equals(CommodityDetail)).ToList();
            return Docs;
        }

        public Doc GetById(int Id)
        {
            return _CommodityDataContext.Docs.Find(Id);
        }

        public Doc Update(Doc doc)
        {
            var UpdateDoc = _CommodityDataContext.Docs.FirstOrDefault(
                e => e.Id.Equals(doc.Id));

            UpdateDoc.DetailofSCommodity = doc.DetailofSCommodity;
            UpdateDoc.DocRoute = doc.DocRoute;
            UpdateDoc.NameofDoc = doc.NameofDoc;

            _CommodityDataContext.Docs.Update(UpdateDoc);
            _CommodityDataContext.SaveChanges();

            return UpdateDoc;
        }
    }
}
