using MatBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.Service
{
    interface IMatFileManager
    {
        Task UploadAsync(IMatFileUploadEntry MatFile);
    }
}
