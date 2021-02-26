using MatBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.Service
{
    interface ICommodityFileManager
    {
        Task UploadExampleImage(IMatFileUploadEntry ImageFile);
        Task UploadExampleImage(IMatFileUploadEntry ImageFile, string path);
    }
}
