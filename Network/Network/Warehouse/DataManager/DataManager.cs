using System.Collections.Generic;
using System.Linq;
using Warehouse;
using Warehouse.IDataManager;
using Warehouse.Model;

public class WarehouseManager : IBaseManager
{
   private readonly WarehouseDataContext _WarehouseDataContext;

    public WarehouseManager(WarehouseDataContext WarehouseDataContext)
    {
        _WarehouseDataContext = WarehouseDataContext;
    }

   public Base Add(Base Base)
   {
       _WarehouseDataContext.Bases.Add(Base);
       _WarehouseDataContext.SaveChanges();

       return _WarehouseDataContext.Bases.OrderByDescending(e=>e.Id).FirstOrDefault();
   }

   public void DeleteById(int Id)
   {
       _WarehouseDataContext.Bases.Remove(GetById(Id));
       _WarehouseDataContext.SaveChanges();
   }
   public void DeleteByWarehouse(Base Base)
   {
        _WarehouseDataContext.Remove(Base);
        _WarehouseDataContext.SaveChanges();
   }
   public Base GetById(int Id)
   {
       return _WarehouseDataContext.Bases.Find(Id);
   }
   public Base Update(Base Base)
   {
       _WarehouseDataContext.Bases.Update(Base);
       _WarehouseDataContext.SaveChanges();

       return GetById(Base.Id);
   }
   public List<Base> GetToList()
   {
      return _WarehouseDataContext.Bases.ToList();
   }
}

public class WCommodityManager : IWCommodityManager
{
    private readonly WarehouseDataContext _WarehouseDataContext;

    public WCommodityManager(WarehouseDataContext WarehouseDataContext)
    {
        _WarehouseDataContext = WarehouseDataContext;
    }

   public WCommodity Add(WCommodity WCommodity)
   {
       _WarehouseDataContext.WCommodities.Add(WCommodity));
       _WarehouseDataContext.SaveChanges();

       return _WarehouseDataContext.WCommodities.OrderByDescending(e=>e.Id).FirstOrDefault();
   }

   public void DeleteById(int Id)
   {
       _WarehouseDataContext.WCommodities.Remove(GetById(Id));
       _WarehouseDataContext.SaveChanges();
   }

   public void DeleteByWCommodity(WCommodity WCommodity)
   {
       _WarehouseDataContext.WCommodities.Remove(WCommodity);
        _WarehouseDataContext.SaveChanges();
   }

   public WCommodity GetById(int Id)
   {
        return _WarehouseDataContext.WCommodities.Find(Id);
   }

   public WCommodity Update(WCommodity WCommodity)
   {
       _WarehouseDataContext.WCommodities.Update(WCommodit);
       _WarehouseDataContext.SaveChanges();

       return GetById(WCommodity.Id);
   }

   public List<WCommodity> GetToList()
   {
       return _WarehouseDataContext.WCommodities.ToList();
   }

}

public class DividedCommodityManager : IDividedCommodityManager
{
    private readonly WarehouseDataContext _WarehouseDataContext;

    public DividedCommodityManager(WarehouseDataContext WarehouseDataContext)
    {
        _WarehouseDataContext = WarehouseDataContext;
    }

   public DividedCommodity Add(DividedCommodity DividedCommodity)
   {
       WarehouseDataContext.DividedCommodities.Add(DividedCommodity);
       _WarehouseDataContext.SaveChanges();

       return _WarehouseDataContext.DividedCommodities.OrderByDescending(e=>e.Id).FirstOrDefault();
   }

   public void DeleteById(int Id)
   {
       _WarehouseDataContext.DividedCommodities.Remove(GetById(Id));
       _WarehouseDataContext.SaveChanges();
   }

   public void DeleteByDividedCommodity(DividedCommodity DividedCommodity)
   {
       _WarehouseDataContext.DividedCommodities.Remove(DividedCommodity);
        _WarehouseDataContext.SaveChanges();
   }

   public DividedCommodity GetById(int Id)
   {
        return _WarehouseDataContext.DividedCommodities.Find(Id);
   }

   public DividedCommodity Update(DividedCommodity DividedCommodity)
   {
       _WarehouseDataContext.DividedCommodities.Update(DividedCommodity);
       _WarehouseDataContext.SaveChanges();

       return GetById(DividedCommodity.Id);
   }

   public List<DividedCommodity> GetToList()
   {
       return _WarehouseDataContext.DividedCommodities.ToList();
   }
}

public class OutgoingCommodityManager : IOutgoingCommodityManager
{
    private readonly WarehouseDataContext _WarehouseDataContext;

    public OutgoingCommodityManager(WarehouseDataContext WarehouseDataContext)
    {
        _WarehouseDataContext = WarehouseDataContext;
    }

   public OutgoingCommodity Add(OutgoingCommodity OutgoingCommodity)
   {
       WarehouseDataContext.OutgoingCommodities.Add(OutgoingCommodity);
       _WarehouseDataContext.SaveChanges();

       return _WarehouseDataContext.OutgoingCommodities.OrderByDescending(e=>e.Id).FirstOrDefault();
   }

   public void DeleteById(int Id)
   {
       _WarehouseDataContext.OutgoingCommodities.Remove(GetById(Id));
       _WarehouseDataContext.SaveChanges();
   }

   public void DeleteByOutgoingCommodity(OutgoingCommodity OutgoingCommodity)
   {
       _WarehouseDataContext.OutgoingCommodities.Remove(OutgoingCommodity);
        _WarehouseDataContext.SaveChanges();
   }

   public OutgoingCommodity GetById(int Id)
   {
        return _WarehouseDataContext.OutgoingCommodities.Find(Id);
   }

   public OutgoingCommodity Update(OutgoingCommodity OutgoingCommodity)
   {
       _WarehouseDataContext.OutgoingCommodities.Update(OutgoingCommodity);
       _WarehouseDataContext.SaveChanges();

       return GetById(OutgoingCommodity.Id);
   }

   public List<OutgoingCommodity> GetToList()
   {
       return _WarehouseDataContext.OutgoingCommodities.ToList();
   }
}

public class PackManager : IPackManager
{
    private readonly WarehouseDataContext _WarehouseDataContext;

    public PackManager(WarehouseDataContext WarehouseDataContext)
    {
        _WarehouseDataContext = WarehouseDataContext;
    }

   public Pack Add(Pack Pack)
   {
       WarehouseDataContext.Packs.Add(Pack);
       _WarehouseDataContext.SaveChanges();

       return _WarehouseDataContext.Packs.OrderByDescending(e=>e.Id).FirstOrDefault();
   }

   public void DeleteById(int Id)
   {
       _WarehouseDataContext.Packs.Remove(GetById(Id));
       _WarehouseDataContext.SaveChanges();
   }

   public void DeleteByPack(Pack Pack)
   {
       _WarehouseDataContext.Packs.Remove(Pack);
        _WarehouseDataContext.SaveChanges();
   }

   public Pack GetById(int Id)
   {
        return _WarehouseDataContext.Packs.Find(Id);
   }

   public Pack Update(Pack Pack)
   {
       _WarehouseDataContext.Packs.Update(Pack);
       _WarehouseDataContext.SaveChanges();

       return GetById(Pack.Id);
   }

   public List<OutgoingCommodity> GetToList()
   {
       return _WarehouseDataContext.Packs.ToList();
   }
}

public class ImageofPackManager : IImageofPackManager
{
    private readonly WarehouseDataContext _WarehouseDataContext;

    public ImageofPackManager(WarehouseDataContext WarehouseDataContext)
    {
        _WarehouseDataContext = WarehouseDataContext;
    }

   public ImageofPack Add(ImageofPack ImageofPack)
   {
       WarehouseDataContext.ImageofPacks.Add(ImageofPack);
       _WarehouseDataContext.SaveChanges();

       return _WarehouseDataContext.ImageofPacks.OrderByDescending(e=>e.Id).FirstOrDefault();
   }

   public void DeleteById(int Id)
   {
       _WarehouseDataContext.ImageofPacks.Remove(GetById(Id));
       _WarehouseDataContext.SaveChanges();
   }

   public void DeleteByImageofPack(ImageofPack ImageofPack)
   {
       _WarehouseDataContext.ImageofPacks.Remove(ImageofPack);
        _WarehouseDataContext.SaveChanges();
   }

   public ImageofPack GetById(int Id)
   {
        return _WarehouseDataContext.ImageofPacks.Find(Id);
   }

   public ImageofPack Update(ImageofPack ImageofPack)
   {
       _WarehouseDataContext.ImageofPacks.Update(ImageofPack);
       _WarehouseDataContext.SaveChanges();

       return GetById(ImageofPack.Id);
   }

   public List<OutgoingCommodity> GetToList()
   {
       return _WarehouseDataContext.ImageofPacks.ToList();
   }
}

public class IncomingTagManager : IIncomingTagManager
{
    private readonly WarehouseDataContext _WarehouseDataContext;

    public IncomingTagManager(WarehouseDataContext WarehouseDataContext)
    {
        _WarehouseDataContext = WarehouseDataContext;
    }

    public IncomingTag Add(IncomingTag IncomingTag)
   {
       WarehouseDataContext.IncomingTags.Add(IncomingTag);
       _WarehouseDataContext.SaveChanges();

       return _WarehouseDataContext.IncomingTags.OrderByDescending(e=>e.Id).FirstOrDefault();
   }

   public void DeleteById(int Id)
   {
       _WarehouseDataContext.IncomingTags.Remove(GetById(Id));
       _WarehouseDataContext.SaveChanges();
   }

   public void DeleteByIncomingTag(IncomingTag IncomingTag)
   {
       _WarehouseDataContext.IncomingTags.Remove(IncomingTag);
        _WarehouseDataContext.SaveChanges();
   }

   public IncomingTag GetById(int Id)
   {
        return _WarehouseDataContext.IncomingTags.Find(Id);
   }

   public IncomingTag Update(IncomingTag IncomingTag)
   {
       _WarehouseDataContext.IncomingTags.Update(IncomingTag);
       _WarehouseDataContext.SaveChanges();

       return GetById(IncomingTag.Id);
   }

   public List<OutgoingCommodity> GetToList()
   {
       return _WarehouseDataContext.IncomingTags.ToList();
   }
}

public class DividedTagManager : IDividedTagManager
{
    private readonly WarehouseDataContext _WarehouseDataContext;

    public DividedTagManager(WarehouseDataContext WarehouseDataContext)
    {
        _WarehouseDataContext = WarehouseDataContext;
    }
    
    public DividedTag Add(DividedTag DividedTag)
   {
       WarehouseDataContext.DividedTags.Add(DividedTag);
       _WarehouseDataContext.SaveChanges();

       return _WarehouseDataContext.DividedTags.OrderByDescending(e=>e.Id).FirstOrDefault();
   }

   public void DeleteById(int Id)
   {
       _WarehouseDataContext.DividedTags.Remove(GetById(Id));
       _WarehouseDataContext.SaveChanges();
   }

   public void DeleteByDividedTag(DividedTag DividedTag)
   {
       _WarehouseDataContext.DividedTags.Remove(DividedTag);
        _WarehouseDataContext.SaveChanges();
   }

   public DividedTag GetById(int Id)
   {
        return _WarehouseDataContext.DividedTags.Find(Id);
   }

   public DividedTag Update(DividedTag DividedTag)
   {
       _WarehouseDataContext.DividedTags.Update(DividedTag);
       _WarehouseDataContext.SaveChanges();

       return GetById(DividedTag.Id);
   }

   public List<OutgoingCommodity> GetToList()
   {
       return _WarehouseDataContext.DividedTags.ToList();
   }
}

public class LoadFrameManager : ILoadFrameManager
{
    private readonly WarehouseDataContext _WarehouseDataContext;

    public LoadFrameManager(WarehouseDataContext WarehouseDataContext)
    {
        _WarehouseDataContext = WarehouseDataContext;
    }

   public LoadFrame Add(LoadFrame LoadFrame)
   {
       WarehouseDataContext.LoadFrames.Add(LoadFrame);
       _WarehouseDataContext.SaveChanges();

       return _WarehouseDataContext.LoadFrames.OrderByDescending(e=>e.Id).FirstOrDefault();
   }

   public void DeleteById(int Id)
   {
       _WarehouseDataContext.LoadFrames.Remove(GetById(Id));
       _WarehouseDataContext.SaveChanges();
   }

   public void DeleteByLoadFrame(LoadFrame LoadFrame)
   {
       _WarehouseDataContext.LoadFrames.Remove(LoadFrame);
        _WarehouseDataContext.SaveChanges();
   }

   public LoadFrame GetById(int Id)
   {
        return _WarehouseDataContext.LoadFrames.Find(Id);
   }

   public LoadFrame Update(LoadFrame LoadFrame)
   {
       _WarehouseDataContext.LoadFrames.Update(LoadFrame);
       _WarehouseDataContext.SaveChanges();

       return GetById(LoadFrame.Id);
   }

   public List<OutgoingCommodity> GetToList()
   {
       return _WarehouseDataContext.LoadFrames.ToList();
   }
}

public class ImageofCommodityManager : IImageofCommodityManager
{
    private readonly WarehouseDataContext _WarehouseDataContext;

    public ImageofCommodityManager(WarehouseDataContext WarehouseDataContext)
    {
        _WarehouseDataContext = WarehouseDataContext;
    }

   public ImageofCommodity Add(ImageofCommodity ImageofCommodity)
   {
       WarehouseDataContext.ImagesofCommodity.Add(ImageofCommodity);
       _WarehouseDataContext.SaveChanges();

       return _WarehouseDataContext.ImagesofCommodity.OrderByDescending(e=>e.Id).FirstOrDefault();
   }

   public void DeleteById(int Id)
   {
       _WarehouseDataContext.ImagesofCommodity.Remove(GetById(Id));
       _WarehouseDataContext.SaveChanges();
   }

   public void DeleteByImageofCommodity(ImageofCommodity ImageofCommodity)
   {
       _WarehouseDataContext.ImagesofCommodity.Remove(ImageofCommodity);
        _WarehouseDataContext.SaveChanges();
   }

   public ImageofCommodity GetById(int Id)
   {
        return _WarehouseDataContext.ImagesofCommodity.Find(Id);
   }

   public ImageofCommodity Update(ImageofCommodity ImageofCommodity)
   {
       _WarehouseDataContext.ImagesofCommodity.Update(ImageofCommodity);
       _WarehouseDataContext.SaveChanges();

       return GetById(ImageofCommodity.Id);
   }

   public List<OutgoingCommodity> GetToList()
   {
       return _WarehouseDataContext.IncomingTags.ToList();
   }
}
public class ImageofIncomingManager : IImageofIncomingManager
{
    private readonly WarehouseDataContext _WarehouseDataContext;

    public ImageofIncomingManager(WarehouseDataContext WarehouseDataContext)
    {
        _WarehouseDataContext = WarehouseDataContext;
    }

   public ImageofIncoming Add(ImageofIncoming ImageofIncoming)
   {
       WarehouseDataContext.ImagesofIncoming.Add(ImageofIncoming);
       _WarehouseDataContext.SaveChanges();

       return _WarehouseDataContext.ImagesofIncoming.OrderByDescending(e=>e.Id).FirstOrDefault();
   }

   public void DeleteById(int Id)
   {
       _WarehouseDataContext.ImagesofIncoming.Remove(GetById(Id));
       _WarehouseDataContext.SaveChanges();
   }

   public void DeleteByImageofIncoming(ImageofIncoming ImageofIncoming)
   {
       _WarehouseDataContext.ImagesofIncoming.Remove(ImageofIncoming);
        _WarehouseDataContext.SaveChanges();
   }

   public ImageofIncoming GetById(int Id)
   {
        return _WarehouseDataContext.ImagesofIncoming.Find(Id);
   }

   public ImageofIncoming Update(ImageofIncoming ImageofIncoming)
   {
       _WarehouseDataContext.ImagesofIncoming.Update(ImageofIncoming);
       _WarehouseDataContext.SaveChanges();

       return GetById(ImageofIncoming.Id);
   }

   public List<OutgoingCommodity> GetToList()
   {
       return _WarehouseDataContext.ImagesofIncoming.ToList();
   }
}

public class ImageofLoadingManager : IImageofLoadingManager
{
    private readonly WarehouseDataContext _WarehouseDataContext;

    public ImageofLoadingManager(WarehouseDataContext WarehouseDataContext)
    {
        _WarehouseDataContext = WarehouseDataContext;
    }

   public ImageofLoading Add(ImageofLoading ImageofLoading)
   {
       WarehouseDataContext.ImageofLoadings.Add(ImageofLoading);
       _WarehouseDataContext.SaveChanges();

       return _WarehouseDataContext.ImagesofLoading.OrderByDescending(e=>e.Id).FirstOrDefault();
   }

   public void DeleteById(int Id)
   {
       _WarehouseDataContext.ImagesofLoading.Remove(GetById(Id));
       _WarehouseDataContext.SaveChanges();
   }

   public void DeleteByImageofLoading(ImageofLoading ImageofLoading)
   {
       _WarehouseDataContext.ImagesofLoading.Remove(ImageofLoading);
        _WarehouseDataContext.SaveChanges();
   }

   public ImageofLoading GetById(int Id)
   {
        return _WarehouseDataContext.ImagesofLoading.Find(Id);
   }

   public ImageofLoading Update(ImageofLoading ImageofLoading)
   {
       _WarehouseDataContext.ImagesofLoading.Update(ImageofLoading);
       _WarehouseDataContext.SaveChanges();

       return GetById(ImageofLoading.Id);
   }

   public List<OutgoingCommodity> GetToList()
   {
       return _WarehouseDataContext.ImagesofLoading.ToList();
   }
}

public class ImageofOutgoingManager : IImageofOutgoingManager
{
    private readonly WarehouseDataContext _WarehouseDataContext;

    public ImageofOutgoingManager(WarehouseDataContext WarehouseDataContext)
    {
        _WarehouseDataContext = WarehouseDataContext;
    }

   public ImageofOutgoing Add(ImageofOutgoing ImageofOutgoing)
   {
       WarehouseDataContext.ImagesofOutgoing.Add(ImageofOutgoing);
       _WarehouseDataContext.SaveChanges();

       return _WarehouseDataContext.ImagesofOutgoing.OrderByDescending(e=>e.Id).FirstOrDefault();
   }

   public void DeleteById(int Id)
   {
       _WarehouseDataContext.ImagesofOutgoing.Remove(GetById(Id));
       _WarehouseDataContext.SaveChanges();
   }

   public void DeleteByImageofOutgoing(ImageofOutgoing ImageofOutgoing)
   {
       _WarehouseDataContext.ImagesofOutgoing.Remove(ImageofOutgoing);
        _WarehouseDataContext.SaveChanges();
   }

   public ImageofOutgoing GetById(int Id)
   {
        return _WarehouseDataContext.ImagesofOutgoing.Find(Id);
   }

   public ImageofOutgoing Update(ImageofOutgoing ImageofOutgoing)
   {
       _WarehouseDataContext.ImagesofOutgoing.Update(ImageofOutgoing);
       _WarehouseDataContext.SaveChanges();

       return GetById(ImageofOutgoing.Id);
   }

   public List<OutgoingCommodity> GetToList()
   {
       return _WarehouseDataContext.ImagesofOutgoiong.ToList();
   }
}

public class ImageofDeliveringManager : IImageofDeliveringManager
{

   private readonly WarehouseDataContext _WarehouseDataContext;

   public ImageofDeliveringManager(WarehouseDataContext WarehouseDataContext)
    {
        _WarehouseDataContext = WarehouseDataContext;
    }
   
    public ImageofDelivering Add(ImageofDelivering ImageofDelivering)
   {
       WarehouseDataContext.ImagesofDelivering.Add(ImageofDelivering);
       _WarehouseDataContext.SaveChanges();

       return _WarehouseDataContext.ImagesofDelivering.OrderByDescending(e=>e.Id).FirstOrDefault();
   }

   public void DeleteById(int Id)
   {
       _WarehouseDataContext.ImagesofDelivering.Remove(GetById(Id));
       _WarehouseDataContext.SaveChanges();
   }

   public void DeleteByImageofDelivering(ImageofDelivering ImageofDelivering)
   {
       _WarehouseDataContext.ImagesofDelivering.Remove(ImageofDelivering);
        _WarehouseDataContext.SaveChanges();
   }

   public ImageofDelivering GetById(int Id)
   {
        return _WarehouseDataContext.ImagesofDelivering.Find(Id);
   }

   public ImageofDelivering Update(ImageofDelivering ImageofDelivering)
   {
       _WarehouseDataContext.ImagesofDelivering.Update(ImageofDelivering);
       _WarehouseDataContext.SaveChanges();

       return GetById(ImageofDelivering.Id);
   }

   public List<OutgoingCommodity> GetToList()
   {
       return _WarehouseDataContext.ImagesofDelivering.ToList();
   }
}

