using BlazorInputFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.Service
{
    public interface IFileManager
    {
        Task UploadAsync(IFileListEntry file);
    }


}
