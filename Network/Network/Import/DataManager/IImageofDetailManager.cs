using Import.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Import.DataManager
{
    public interface IImageofDetailManager
    {
        void Add(ImageofDetail Image);
        void DeleteById(int ImageNo);
        ImageofDetail GetById(int ImageNo);
        void Update(ImageofDetail Image);
        List<ImageofDetail> GetByOptionToList(ImageofOption option);


        Task<ImageofDetail> GetByEntity(ImageofDetail Detail);
    }
}
