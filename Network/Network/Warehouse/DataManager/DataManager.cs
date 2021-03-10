using System.Collections.Generic;
using System.Linq;
using Warehouse;
using Warehouse.IDataManager;
using Warehouse.Model;

namespace Warehouse.DataManager
{
    public class BaseManager : IBaseManager
    {
        private readonly WCommodityDataContext _WCommodityDataContext;

        public BaseManager(WCommodityDataContext WCommodityDataContext)
        {
            _WCommodityDataContext = WCommodityDataContext;
        }

        public Base Add(Base Base)
        {
            _WCommodityDataContext.Bases.Add(Base);
            _WCommodityDataContext.SaveChanges();

            return _WCommodityDataContext.Bases.OrderByDescending(e => e.Id).FirstOrDefault();
        }

        public void DeleteById(int Id)
        {
            _WCommodityDataContext.Bases.Remove(GetById(Id));
            _WCommodityDataContext.SaveChanges();
        }
        public void DeleteByBase(Base Base)
        {
            _WCommodityDataContext.Remove(Base);
            _WCommodityDataContext.SaveChanges();
        }
        public Base GetById(int Id)
        {
            return _WCommodityDataContext.Bases.Find(Id);
        }
        public Base Update(Base Base)
        {
            _WCommodityDataContext.Bases.Update(Base);
            _WCommodityDataContext.SaveChanges();

            return GetById(Base.Id);
        }
        public List<Base> GetToList()
        {
            return _WCommodityDataContext.Bases.ToList();
        }
    }

    public class WCommodityManager : IWCommodityManager
    {
        private readonly WCommodityDataContext _WCommodityDataContext;

        public WCommodityManager(WCommodityDataContext WCommodityDataContext)
        {
            _WCommodityDataContext = WCommodityDataContext;
        }

        public WCommodity Add(WCommodity WCommodity)
        {
            _WCommodityDataContext.WCommodities.Add(WCommodity);
            _WCommodityDataContext.SaveChanges();

            return _WCommodityDataContext.WCommodities.OrderByDescending(e => e.Id).FirstOrDefault();
        }

        public void DeleteById(int Id)
        {
            _WCommodityDataContext.WCommodities.Remove(GetById(Id));
            _WCommodityDataContext.SaveChanges();
        }

        public void DeleteByWCommodity(WCommodity WCommodity)
        {
            _WCommodityDataContext.WCommodities.Remove(WCommodity);
            _WCommodityDataContext.SaveChanges();
        }

        public WCommodity GetById(int Id)
        {
            return _WCommodityDataContext.WCommodities.Find(Id);
        }

        public WCommodity Update(WCommodity WCommodity)
        {
            _WCommodityDataContext.WCommodities.Update(WCommodity);
            _WCommodityDataContext.SaveChanges();

            return GetById(WCommodity.Id);
        }

        public List<WCommodity> GetToList()
        {
            return _WCommodityDataContext.WCommodities.ToList();
        }

    }

    public class DividedCommodityManager : IDividedCommodityManager
    {
        private readonly WCommodityDataContext _WCommodityDataContext;

        public DividedCommodityManager(WCommodityDataContext WCommodityDataContext)
        {
            _WCommodityDataContext = WCommodityDataContext;
        }

        public DividedCommodity Add(DividedCommodity DividedCommodity)
        {
            _WCommodityDataContext.DividedCommodities.Add(DividedCommodity);
            _WCommodityDataContext.SaveChanges();

            return _WCommodityDataContext.DividedCommodities.OrderByDescending(e => e.Id).FirstOrDefault();
        }

        public void DeleteById(int Id)
        {
            _WCommodityDataContext.DividedCommodities.Remove(GetById(Id));
            _WCommodityDataContext.SaveChanges();
        }

        public void DeleteByDividedCommodity(DividedCommodity DividedCommodity)
        {
            _WCommodityDataContext.DividedCommodities.Remove(DividedCommodity);
            _WCommodityDataContext.SaveChanges();
        }

        public DividedCommodity GetById(int Id)
        {
            return _WCommodityDataContext.DividedCommodities.Find(Id);
        }

        public DividedCommodity Update(DividedCommodity DividedCommodity)
        {
            _WCommodityDataContext.DividedCommodities.Update(DividedCommodity);
            _WCommodityDataContext.SaveChanges();

            return GetById(DividedCommodity.Id);
        }

        public List<DividedCommodity> GetToList()
        {
            return _WCommodityDataContext.DividedCommodities.ToList();
        }
    }

    public class OutgoingCommodityManager : IOutgoingCommodityManager
    {
        private readonly WCommodityDataContext _WCommodityDataContext;

        public OutgoingCommodityManager(WCommodityDataContext WCommodityDataContext)
        {
            _WCommodityDataContext = WCommodityDataContext;
        }

        public OutgoingCommodity Add(OutgoingCommodity OutgoingCommodity)
        {
            _WCommodityDataContext.OutgoingCommodities.Add(OutgoingCommodity);
            _WCommodityDataContext.SaveChanges();

            return _WCommodityDataContext.OutgoingCommodities.OrderByDescending(e => e.Id).FirstOrDefault();
        }

        public void DeleteById(int Id)
        {
            _WCommodityDataContext.OutgoingCommodities.Remove(GetById(Id));
            _WCommodityDataContext.SaveChanges();
        }

        public void DeleteByOutgoingCommodity(OutgoingCommodity OutgoingCommodity)
        {
            _WCommodityDataContext.OutgoingCommodities.Remove(OutgoingCommodity);
            _WCommodityDataContext.SaveChanges();
        }

        public OutgoingCommodity GetById(int Id)
        {
            return _WCommodityDataContext.OutgoingCommodities.Find(Id);
        }

        public OutgoingCommodity Update(OutgoingCommodity OutgoingCommodity)
        {
            _WCommodityDataContext.OutgoingCommodities.Update(OutgoingCommodity);
            _WCommodityDataContext.SaveChanges();

            return GetById(OutgoingCommodity.Id);
        }

        public List<OutgoingCommodity> GetToList()
        {
            return _WCommodityDataContext.OutgoingCommodities.ToList();
        }
    }

    public class PackManager : IPackManager
    {
        private readonly WCommodityDataContext _WCommodityDataContext;

        public PackManager(WCommodityDataContext WCommodityDataContext)
        {
            _WCommodityDataContext = WCommodityDataContext;
        }

        public Pack Add(Pack Pack)
        {
            _WCommodityDataContext.Packs.Add(Pack);
            _WCommodityDataContext.SaveChanges();

            return _WCommodityDataContext.Packs.OrderByDescending(e => e.Id).FirstOrDefault();
        }

        public void DeleteById(int Id)
        {
            _WCommodityDataContext.Packs.Remove(GetById(Id));
            _WCommodityDataContext.SaveChanges();
        }

        public void DeleteByPack(Pack Pack)
        {
            _WCommodityDataContext.Packs.Remove(Pack);
            _WCommodityDataContext.SaveChanges();
        }

        public Pack GetById(int Id)
        {
            return _WCommodityDataContext.Packs.Find(Id);
        }

        public Pack Update(Pack Pack)
        {
            _WCommodityDataContext.Packs.Update(Pack);
            _WCommodityDataContext.SaveChanges();

            return GetById(Pack.Id);
        }

        public List<Pack> GetToList()
        {
            return _WCommodityDataContext.Packs.ToList();
        }
    }

    public class ImageofPackManager : IImageofPackManager
    {
        private readonly WCommodityDataContext _WCommodityDataContext;

        public ImageofPackManager(WCommodityDataContext WCommodityDataContext)
        {
            _WCommodityDataContext = WCommodityDataContext;
        }

        public ImageofPack Add(ImageofPack ImageofPack)
        {
            _WCommodityDataContext.ImagesofPack.Add(ImageofPack);
            _WCommodityDataContext.SaveChanges();

            return _WCommodityDataContext.ImagesofPack.OrderByDescending(e => e.Id).FirstOrDefault();
        }

        public void DeleteById(int Id)
        {
            _WCommodityDataContext.ImagesofPack.Remove(GetById(Id));
            _WCommodityDataContext.SaveChanges();
        }

        public void DeleteByImageofPack(ImageofPack ImageofPack)
        {
            _WCommodityDataContext.ImagesofPack.Remove(ImageofPack);
            _WCommodityDataContext.SaveChanges();
        }

        public ImageofPack GetById(int Id)
        {
            return _WCommodityDataContext.ImagesofPack.Find(Id);
        }

        public ImageofPack Update(ImageofPack ImageofPack)
        {
            _WCommodityDataContext.ImagesofPack.Update(ImageofPack);
            _WCommodityDataContext.SaveChanges();

            return GetById(ImageofPack.Id);
        }

        public List<ImageofPack> GetToList()
        {
            return _WCommodityDataContext.ImagesofPack.ToList();
        }
    }

    public class IncomingTagManager : IIncomingTagManager
    {
        private readonly WCommodityDataContext _WCommodityDataContext;

        public IncomingTagManager(WCommodityDataContext WCommodityDataContext)
        {
            _WCommodityDataContext = WCommodityDataContext;
        }

        public IncomingTag Add(IncomingTag IncomingTag)
        {
            _WCommodityDataContext.IncomingTags.Add(IncomingTag);
            _WCommodityDataContext.SaveChanges();

            return _WCommodityDataContext.IncomingTags.OrderByDescending(e => e.Id).FirstOrDefault();
        }

        public void DeleteById(int Id)
        {
            _WCommodityDataContext.IncomingTags.Remove(GetById(Id));
            _WCommodityDataContext.SaveChanges();
        }

        public void DeleteByIncomingTag(IncomingTag IncomingTag)
        {
            _WCommodityDataContext.IncomingTags.Remove(IncomingTag);
            _WCommodityDataContext.SaveChanges();
        }

        public IncomingTag GetById(int Id)
        {
            return _WCommodityDataContext.IncomingTags.Find(Id);
        }

        public IncomingTag Update(IncomingTag IncomingTag)
        {
            _WCommodityDataContext.IncomingTags.Update(IncomingTag);
            _WCommodityDataContext.SaveChanges();

            return GetById(IncomingTag.Id);
        }

        public List<IncomingTag> GetToList()
        {
            return _WCommodityDataContext.IncomingTags.ToList();
        }
    }

    public class DividedTagManager : IDividedTagManager
    {
        private readonly WCommodityDataContext _WCommodityDataContext;

        public DividedTagManager(WCommodityDataContext WCommodityDataContext)
        {
            _WCommodityDataContext = WCommodityDataContext;
        }

        public DividedTag Add(DividedTag DividedTag)
        {
            _WCommodityDataContext.DividedTags.Add(DividedTag);
            _WCommodityDataContext.SaveChanges();

            return _WCommodityDataContext.DividedTags.OrderByDescending(e => e.Id).FirstOrDefault();
        }

        public void DeleteById(int Id)
        {
            _WCommodityDataContext.DividedTags.Remove(GetById(Id));
            _WCommodityDataContext.SaveChanges();
        }

        public void DeleteByDividedTag(DividedTag DividedTag)
        {
            _WCommodityDataContext.DividedTags.Remove(DividedTag);
            _WCommodityDataContext.SaveChanges();
        }

        public DividedTag GetById(int Id)
        {
            return _WCommodityDataContext.DividedTags.Find(Id);
        }

        public DividedTag Update(DividedTag DividedTag)
        {
            _WCommodityDataContext.DividedTags.Update(DividedTag);
            _WCommodityDataContext.SaveChanges();

            return GetById(DividedTag.Id);
        }

        public List<DividedTag> GetToList()
        {
            return _WCommodityDataContext.DividedTags.ToList();
        }
    }

    public class LoadFrameManager : ILoadFrameManager
    {
        private readonly WCommodityDataContext _WCommodityDataContext;

        public LoadFrameManager(WCommodityDataContext WCommodityDataContext)
        {
            _WCommodityDataContext = WCommodityDataContext;
        }

        public LoadFrame Add(LoadFrame LoadFrame)
        {
            _WCommodityDataContext.LoadFrames.Add(LoadFrame);
            _WCommodityDataContext.SaveChanges();

            return _WCommodityDataContext.LoadFrames.OrderByDescending(e => e.Id).FirstOrDefault();
        }

        public void DeleteById(int Id)
        {
            _WCommodityDataContext.LoadFrames.Remove(GetById(Id));
            _WCommodityDataContext.SaveChanges();
        }

        public void DeleteByLoadFrame(LoadFrame LoadFrame)
        {
            _WCommodityDataContext.LoadFrames.Remove(LoadFrame);
            _WCommodityDataContext.SaveChanges();
        }

        public LoadFrame GetById(int Id)
        {
            return _WCommodityDataContext.LoadFrames.Find(Id);
        }

        public LoadFrame Update(LoadFrame LoadFrame)
        {
            _WCommodityDataContext.LoadFrames.Update(LoadFrame);
            _WCommodityDataContext.SaveChanges();

            return GetById(LoadFrame.Id);
        }

        public List<LoadFrame> GetToList()
        {
            return _WCommodityDataContext.LoadFrames.ToList();
        }
    }

    public class ImageofWCommodityManager : IImageofWCommodityManager
    {
        private readonly WCommodityDataContext _WCommodityDataContext;

        public ImageofWCommodityManager(WCommodityDataContext WCommodityDataContext)
        {
            _WCommodityDataContext = WCommodityDataContext;
        }

        public ImageofWCommodity Add(ImageofWCommodity ImageofWCommodity)
        {
            _WCommodityDataContext.ImagesofWCommodity.Add(ImageofWCommodity);
            _WCommodityDataContext.SaveChanges();

            return _WCommodityDataContext.ImagesofWCommodity.OrderByDescending(e => e.Id).FirstOrDefault();
        }

        public void DeleteById(int Id)
        {
            _WCommodityDataContext.ImagesofWCommodity.Remove(GetById(Id));
            _WCommodityDataContext.SaveChanges();
        }

        public void DeleteByImageofWCommodity(ImageofWCommodity ImageofWCommodity)
        {
            _WCommodityDataContext.ImagesofWCommodity.Remove(ImageofWCommodity);
            _WCommodityDataContext.SaveChanges();
        }

        public ImageofWCommodity GetById(int Id)
        {
            return _WCommodityDataContext.ImagesofWCommodity.Find(Id);
        }

        public ImageofWCommodity Update(ImageofWCommodity ImageofWCommodity)
        {
            _WCommodityDataContext.ImagesofWCommodity.Update(ImageofWCommodity);
            _WCommodityDataContext.SaveChanges();

            return GetById(ImageofWCommodity.Id);
        }

        public List<ImageofWCommodity> GetToList()
        {
            return _WCommodityDataContext.ImagesofWCommodity.ToList();
        }
    }
    public class ImageofIncomingManager : IImageofIncomingManager
    {
        private readonly WCommodityDataContext _WCommodityDataContext;

        public ImageofIncomingManager(WCommodityDataContext WCommodityDataContext)
        {
            _WCommodityDataContext = WCommodityDataContext;
        }

        public ImageofIncoming Add(ImageofIncoming ImageofIncoming)
        {
            _WCommodityDataContext.ImagesofIncoming.Add(ImageofIncoming);
            _WCommodityDataContext.SaveChanges();

            return _WCommodityDataContext.ImagesofIncoming.OrderByDescending(e => e.Id).FirstOrDefault();
        }

        public void DeleteById(int Id)
        {
            _WCommodityDataContext.ImagesofIncoming.Remove(GetById(Id));
            _WCommodityDataContext.SaveChanges();
        }

        public void DeleteByImageofIncoming(ImageofIncoming ImageofIncoming)
        {
            _WCommodityDataContext.ImagesofIncoming.Remove(ImageofIncoming);
            _WCommodityDataContext.SaveChanges();
        }

        public ImageofIncoming GetById(int Id)
        {
            return _WCommodityDataContext.ImagesofIncoming.Find(Id);
        }

        public ImageofIncoming Update(ImageofIncoming ImageofIncoming)
        {
            _WCommodityDataContext.ImagesofIncoming.Update(ImageofIncoming);
            _WCommodityDataContext.SaveChanges();

            return GetById(ImageofIncoming.Id);
        }

        public List<ImageofIncoming> GetToList()
        {
            return _WCommodityDataContext.ImagesofIncoming.ToList();
        }
    }

    public class ImageofLoadingManager : IImageofLoadingManager
    {
        private readonly WCommodityDataContext _WCommodityDataContext;

        public ImageofLoadingManager(WCommodityDataContext WCommodityDataContext)
        {
            _WCommodityDataContext = WCommodityDataContext;
        }

        public ImageofLoading Add(ImageofLoading ImageofLoading)
        {
            _WCommodityDataContext.ImagesofLoading.Add(ImageofLoading);
            _WCommodityDataContext.SaveChanges();

            return _WCommodityDataContext.ImagesofLoading.OrderByDescending(e => e.Id).FirstOrDefault();
        }

        public void DeleteById(int Id)
        {
            _WCommodityDataContext.ImagesofLoading.Remove(GetById(Id));
            _WCommodityDataContext.SaveChanges();
        }

        public void DeleteByImageofLoading(ImageofLoading ImageofLoading)
        {
            _WCommodityDataContext.ImagesofLoading.Remove(ImageofLoading);
            _WCommodityDataContext.SaveChanges();
        }

        public ImageofLoading GetById(int Id)
        {
            return _WCommodityDataContext.ImagesofLoading.Find(Id);
        }

        public ImageofLoading Update(ImageofLoading ImageofLoading)
        {
            _WCommodityDataContext.ImagesofLoading.Update(ImageofLoading);
            _WCommodityDataContext.SaveChanges();

            return GetById(ImageofLoading.Id);
        }

        public List<ImageofLoading> GetToList()
        {
            return _WCommodityDataContext.ImagesofLoading.ToList();
        }
    }

    public class ImageofOutgoingManager : IImageofOutgoingManager
    {
        private readonly WCommodityDataContext _WCommodityDataContext;

        public ImageofOutgoingManager(WCommodityDataContext WCommodityDataContext)
        {
            _WCommodityDataContext = WCommodityDataContext;
        }

        public ImageofOutgoing Add(ImageofOutgoing ImageofOutgoing)
        {
            _WCommodityDataContext.ImagesofOutgoing.Add(ImageofOutgoing);
            _WCommodityDataContext.SaveChanges();

            return _WCommodityDataContext.ImagesofOutgoing.OrderByDescending(e => e.Id).FirstOrDefault();
        }

        public void DeleteById(int Id)
        {
            _WCommodityDataContext.ImagesofOutgoing.Remove(GetById(Id));
            _WCommodityDataContext.SaveChanges();
        }

        public void DeleteByImageofOutgoing(ImageofOutgoing ImageofOutgoing)
        {
            _WCommodityDataContext.ImagesofOutgoing.Remove(ImageofOutgoing);
            _WCommodityDataContext.SaveChanges();
        }

        public ImageofOutgoing GetById(int Id)
        {
            return _WCommodityDataContext.ImagesofOutgoing.Find(Id);
        }

        public ImageofOutgoing Update(ImageofOutgoing ImageofOutgoing)
        {
            _WCommodityDataContext.ImagesofOutgoing.Update(ImageofOutgoing);
            _WCommodityDataContext.SaveChanges();

            return GetById(ImageofOutgoing.Id);
        }

        public List<ImageofOutgoing> GetToList()
        {
            return _WCommodityDataContext.ImagesofOutgoing.ToList();
        }
    }

    public class ImageofDeliveringManager : IImageofDeliveringManager
    {

        private readonly WCommodityDataContext _WCommodityDataContext;

        public ImageofDeliveringManager(WCommodityDataContext WCommodityDataContext)
        {
            _WCommodityDataContext = WCommodityDataContext;
        }

        public ImageofDelivering Add(ImageofDelivering ImageofDelivering)
        {
            _WCommodityDataContext.ImagesofDelivering.Add(ImageofDelivering);
            _WCommodityDataContext.SaveChanges();

            return _WCommodityDataContext.ImagesofDelivering.OrderByDescending(e => e.Id).FirstOrDefault();
        }

        public void DeleteById(int Id)
        {
            _WCommodityDataContext.ImagesofDelivering.Remove(GetById(Id));
            _WCommodityDataContext.SaveChanges();
        }

        public void DeleteByImageofDelivering(ImageofDelivering ImageofDelivering)
        {
            _WCommodityDataContext.ImagesofDelivering.Remove(ImageofDelivering);
            _WCommodityDataContext.SaveChanges();
        }

        public ImageofDelivering GetById(int Id)
        {
            return _WCommodityDataContext.ImagesofDelivering.Find(Id);
        }

        public ImageofDelivering Update(ImageofDelivering ImageofDelivering)
        {
            _WCommodityDataContext.ImagesofDelivering.Update(ImageofDelivering);
            _WCommodityDataContext.SaveChanges();

            return GetById(ImageofDelivering.Id);
        }

        public List<ImageofDelivering> GetToList()
        {
            return _WCommodityDataContext.ImagesofDelivering.ToList();
        }
    }

}