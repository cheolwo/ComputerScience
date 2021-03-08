public class WarehouseManager : IWarehouseManager
{
   private readonly WarehouseDataContext _WarehouseDataContext;

    public WarehouseManager(WarehouseDataContext WarehouseDataContext)
    {
        _WarehouseDataContext = WarehouseDataContext;
    }

   public Warehouse Add(Warehouse Warehouse)
   {
       _WarehouseDataContext.Warehouses.Add(Warehouse);
       _WarehouseDataContext.SaveChanges();

       return _WarehouseDataContext.Warehouses.OrderByDescending(e=>e.WarehouseNo).FirstOrDefault();
   }

   public void DeleteById(int WarehouseNo)
   {
       _WarehouseDataContext.Warehouses.Remove(GetById(WarehouseNo));
       _WarehouseDataContext.SaveChanges();
   }
   public void DeleteByWarehouse(Warehouse Warehouse)
   {
        _WarehouseDataContext.Remove(Warehouse);
        _WarehouseDataContext.SaveChanges();
   }
   public Warehouse GetById(int WarehouseNo)
   {
       return _WarehouseDataContext.Warehouses.Find(WarehouseNo);
   }
   public Warehouse Update(Warehouse Warehouse)
   {
       _WarehouseDataContext.Warehouses.Update(Warehouse);
       _WarehouseDataContext.SaveChanges();

       return GetById(Warehouse.WarehouseNo);
   }
   public List<Warehouse> GetToList()
   {
      return _WarehouseDataContext.Warehouses.ToList();
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
       WarehouseDataContext.WCommodities.Add(WCommodit);
       _WarehouseDataContext.SaveChanges();

       return _WarehouseDataContext.WCommodities.OrderByDescending(e=>e.WCommodityNo).FirstOrDefault();
   }

   public void DeleteById(int WCommodityNo)
   {
       _WarehouseDataContext.WCommodities.Remove(GetById(WCommodityNo));
       _WarehouseDataContext.SaveChanges();
   }

   public void DeleteByWCommodity(WCommodity WCommodity)
   {
       _WarehouseDataContext.WCommodities.Remove(WCommodity);
        _WarehouseDataContext.SaveChanges();
   }

   public WCommodity GetById(int WCommodityNo)
   {
        return _WarehouseDataContext.WCommodities.Find(WCommodityNo);
   }

   public WCommodity Update(WCommodity WCommodity)
   {
       _WarehouseDataContext.WCommodities.Update(WCommodit);
       _WarehouseDataContext.SaveChanges();

       return GetById(WCommodity.WCommodityNo);
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

       return _WarehouseDataContext.DividedCommodities.OrderByDescending(e=>e.DividedCommodityNo).FirstOrDefault();
   }

   public void DeleteById(int DividedCommodityNo)
   {
       _WarehouseDataContext.DividedCommodities.Remove(GetById(DividedCommodityNo));
       _WarehouseDataContext.SaveChanges();
   }

   public void DeleteByDividedCommodity(DividedCommodity DividedCommodity)
   {
       _WarehouseDataContext.DividedCommodities.Remove(DividedCommodity);
        _WarehouseDataContext.SaveChanges();
   }

   public DividedCommodity GetById(int DividedCommodityNo)
   {
        return _WarehouseDataContext.DividedCommodities.Find(DividedCommodityNo);
   }

   public DividedCommodity Update(DividedCommodity DividedCommodity)
   {
       _WarehouseDataContext.DividedCommodities.Update(DividedCommodity);
       _WarehouseDataContext.SaveChanges();

       return GetById(DividedCommodity.DividedCommodityNo);
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

       return _WarehouseDataContext.OutgoingCommodities.OrderByDescending(e=>e.OutgoingCommodityNo).FirstOrDefault();
   }

   public void DeleteById(int OutgoingCommodityNo)
   {
       _WarehouseDataContext.OutgoingCommodities.Remove(GetById(OutgoingCommodityNo));
       _WarehouseDataContext.SaveChanges();
   }

   public void DeleteByOutgoingCommodity(OutgoingCommodity OutgoingCommodity)
   {
       _WarehouseDataContext.OutgoingCommodities.Remove(OutgoingCommodity);
        _WarehouseDataContext.SaveChanges();
   }

   public OutgoingCommodity GetById(int OutgoingCommodityNo)
   {
        return _WarehouseDataContext.OutgoingCommodities.Find(OutgoingCommodityNo);
   }

   public OutgoingCommodity Update(OutgoingCommodity OutgoingCommodity)
   {
       _WarehouseDataContext.OutgoingCommodities.Update(OutgoingCommodity);
       _WarehouseDataContext.SaveChanges();

       return GetById(OutgoingCommodity.OutgoingCommodityNo);
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

       return _WarehouseDataContext.Packs.OrderByDescending(e=>e.PackNo).FirstOrDefault();
   }

   public void DeleteById(int PackNo)
   {
       _WarehouseDataContext.Packs.Remove(GetById(PackNo));
       _WarehouseDataContext.SaveChanges();
   }

   public void DeleteByPack(Pack Pack)
   {
       _WarehouseDataContext.Packs.Remove(Pack);
        _WarehouseDataContext.SaveChanges();
   }

   public Pack GetById(int PackNo)
   {
        return _WarehouseDataContext.Packs.Find(PackNo);
   }

   public Pack Update(Pack Pack)
   {
       _WarehouseDataContext.Packs.Update(Pack);
       _WarehouseDataContext.SaveChanges();

       return GetById(Pack.PackNo);
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

       return _WarehouseDataContext.ImageofPacks.OrderByDescending(e=>e.ImageofPackNo).FirstOrDefault();
   }

   public void DeleteById(int ImageofPackNo)
   {
       _WarehouseDataContext.ImageofPacks.Remove(GetById(ImageofPackNo));
       _WarehouseDataContext.SaveChanges();
   }

   public void DeleteByImageofPack(ImageofPack ImageofPack)
   {
       _WarehouseDataContext.ImageofPacks.Remove(ImageofPack);
        _WarehouseDataContext.SaveChanges();
   }

   public ImageofPack GetById(int ImageofPackNo)
   {
        return _WarehouseDataContext.ImageofPacks.Find(ImageofPackNo);
   }

   public ImageofPack Update(ImageofPack ImageofPack)
   {
       _WarehouseDataContext.ImageofPacks.Update(ImageofPack);
       _WarehouseDataContext.SaveChanges();

       return GetById(ImageofPack.ImageofPackNo);
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

       return _WarehouseDataContext.IncomingTags.OrderByDescending(e=>e.IncomingTagNo).FirstOrDefault();
   }

   public void DeleteById(int IncomingTagNo)
   {
       _WarehouseDataContext.IncomingTags.Remove(GetById(IncomingTagNo));
       _WarehouseDataContext.SaveChanges();
   }

   public void DeleteByIncomingTag(IncomingTag IncomingTag)
   {
       _WarehouseDataContext.IncomingTags.Remove(IncomingTag);
        _WarehouseDataContext.SaveChanges();
   }

   public IncomingTag GetById(int IncomingTagNo)
   {
        return _WarehouseDataContext.IncomingTags.Find(IncomingTagNo);
   }

   public IncomingTag Update(IncomingTag IncomingTag)
   {
       _WarehouseDataContext.IncomingTags.Update(IncomingTag);
       _WarehouseDataContext.SaveChanges();

       return GetById(IncomingTag.IncomingTagNo);
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

       return _WarehouseDataContext.DividedTags.OrderByDescending(e=>e.DividedTagNo).FirstOrDefault();
   }

   public void DeleteById(int DividedTagNo)
   {
       _WarehouseDataContext.DividedTags.Remove(GetById(DividedTagNo));
       _WarehouseDataContext.SaveChanges();
   }

   public void DeleteByDividedTag(DividedTag DividedTag)
   {
       _WarehouseDataContext.DividedTags.Remove(DividedTag);
        _WarehouseDataContext.SaveChanges();
   }

   public DividedTag GetById(int DividedTagNo)
   {
        return _WarehouseDataContext.DividedTags.Find(DividedTagNo);
   }

   public DividedTag Update(DividedTag DividedTag)
   {
       _WarehouseDataContext.DividedTags.Update(DividedTag);
       _WarehouseDataContext.SaveChanges();

       return GetById(DividedTag.DividedTagNo);
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

       return _WarehouseDataContext.LoadFrames.OrderByDescending(e=>e.LoadFrameNo).FirstOrDefault();
   }

   public void DeleteById(int LoadFrameNo)
   {
       _WarehouseDataContext.LoadFrames.Remove(GetById(LoadFrameNo));
       _WarehouseDataContext.SaveChanges();
   }

   public void DeleteByLoadFrame(LoadFrame LoadFrame)
   {
       _WarehouseDataContext.LoadFrames.Remove(LoadFrame);
        _WarehouseDataContext.SaveChanges();
   }

   public LoadFrame GetById(int LoadFrameNo)
   {
        return _WarehouseDataContext.LoadFrames.Find(LoadFrameNo);
   }

   public LoadFrame Update(LoadFrame LoadFrame)
   {
       _WarehouseDataContext.LoadFrames.Update(LoadFrame);
       _WarehouseDataContext.SaveChanges();

       return GetById(LoadFrame.LoadFrameNo);
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

       return _WarehouseDataContext.ImagesofCommodity.OrderByDescending(e=>e.ImageofCommodityNo).FirstOrDefault();
   }

   public void DeleteById(int ImageofCommodityNo)
   {
       _WarehouseDataContext.ImagesofCommodity.Remove(GetById(ImageofCommodityNo));
       _WarehouseDataContext.SaveChanges();
   }

   public void DeleteByImageofCommodity(ImageofCommodity ImageofCommodity)
   {
       _WarehouseDataContext.ImagesofCommodity.Remove(ImageofCommodity);
        _WarehouseDataContext.SaveChanges();
   }

   public ImageofCommodity GetById(int ImageofCommodityNo)
   {
        return _WarehouseDataContext.ImagesofCommodity.Find(ImageofCommodityNo);
   }

   public ImageofCommodity Update(ImageofCommodity ImageofCommodity)
   {
       _WarehouseDataContext.ImagesofCommodity.Update(ImageofCommodity);
       _WarehouseDataContext.SaveChanges();

       return GetById(ImageofCommodity.ImageofCommodityNo);
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

       return _WarehouseDataContext.ImagesofIncoming.OrderByDescending(e=>e.ImageofIncomingNo).FirstOrDefault();
   }

   public void DeleteById(int ImageofIncomingNo)
   {
       _WarehouseDataContext.ImagesofIncoming.Remove(GetById(ImageofIncomingNo));
       _WarehouseDataContext.SaveChanges();
   }

   public void DeleteByImageofIncoming(ImageofIncoming ImageofIncoming)
   {
       _WarehouseDataContext.ImagesofIncoming.Remove(ImageofIncoming);
        _WarehouseDataContext.SaveChanges();
   }

   public ImageofIncoming GetById(int ImageofIncomingNo)
   {
        return _WarehouseDataContext.ImagesofIncoming.Find(ImageofIncomingNo);
   }

   public ImageofIncoming Update(ImageofIncoming ImageofIncoming)
   {
       _WarehouseDataContext.ImagesofIncoming.Update(ImageofIncoming);
       _WarehouseDataContext.SaveChanges();

       return GetById(ImageofIncoming.ImageofIncomingNo);
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

       return _WarehouseDataContext.ImagesofLoading.OrderByDescending(e=>e.ImageofLoadingNo).FirstOrDefault();
   }

   public void DeleteById(int ImageofLoadingNo)
   {
       _WarehouseDataContext.ImagesofLoading.Remove(GetById(ImageofLoadingNo));
       _WarehouseDataContext.SaveChanges();
   }

   public void DeleteByImageofLoading(ImageofLoading ImageofLoading)
   {
       _WarehouseDataContext.ImagesofLoading.Remove(ImageofLoading);
        _WarehouseDataContext.SaveChanges();
   }

   public ImageofLoading GetById(int ImageofLoadingNo)
   {
        return _WarehouseDataContext.ImagesofLoading.Find(ImageofLoadingNo);
   }

   public ImageofLoading Update(ImageofLoading ImageofLoading)
   {
       _WarehouseDataContext.ImagesofLoading.Update(ImageofLoading);
       _WarehouseDataContext.SaveChanges();

       return GetById(ImageofLoading.ImageofLoadingNo);
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

       return _WarehouseDataContext.ImagesofOutgoing.OrderByDescending(e=>e.ImageofOutgoingNo).FirstOrDefault();
   }

   public void DeleteById(int ImageofOutgoingNo)
   {
       _WarehouseDataContext.ImagesofOutgoing.Remove(GetById(ImageofOutgoingNo));
       _WarehouseDataContext.SaveChanges();
   }

   public void DeleteByImageofOutgoing(ImageofOutgoing ImageofOutgoing)
   {
       _WarehouseDataContext.ImagesofOutgoing.Remove(ImageofOutgoing);
        _WarehouseDataContext.SaveChanges();
   }

   public ImageofOutgoing GetById(int ImageofOutgoingNo)
   {
        return _WarehouseDataContext.ImagesofOutgoing.Find(ImageofOutgoingNo);
   }

   public ImageofOutgoing Update(ImageofOutgoing ImageofOutgoing)
   {
       _WarehouseDataContext.ImagesofOutgoing.Update(ImageofOutgoing);
       _WarehouseDataContext.SaveChanges();

       return GetById(ImageofOutgoing.ImageofOutgoingNo);
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

       return _WarehouseDataContext.ImagesofDelivering.OrderByDescending(e=>e.ImageofDeliveringNo).FirstOrDefault();
   }

   public void DeleteById(int ImageofDeliveringNo)
   {
       _WarehouseDataContext.ImagesofDelivering.Remove(GetById(ImageofDeliveringNo));
       _WarehouseDataContext.SaveChanges();
   }

   public void DeleteByImageofDelivering(ImageofDelivering ImageofDelivering)
   {
       _WarehouseDataContext.ImagesofDelivering.Remove(ImageofDelivering);
        _WarehouseDataContext.SaveChanges();
   }

   public ImageofDelivering GetById(int ImageofDeliveringNo)
   {
        return _WarehouseDataContext.ImagesofDelivering.Find(ImageofDeliveringNo);
   }

   public ImageofDelivering Update(ImageofDelivering ImageofDelivering)
   {
       _WarehouseDataContext.ImagesofDelivering.Update(ImageofDelivering);
       _WarehouseDataContext.SaveChanges();

       return GetById(ImageofDelivering.ImageofDeliveringNo);
   }

   public List<OutgoingCommodity> GetToList()
   {
       return _WarehouseDataContext.ImagesofDelivering.ToList();
   }
}

