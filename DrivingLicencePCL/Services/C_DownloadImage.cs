using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DrivingLicenceServerPCL.Services;

namespace DrivingLicencePCL.Services
{
    public static class C_DownloadImage
    {
        public static string DownloadImage(string file)
        {
            return DrivingLicenceServerPCL.Services.Services.DownloadImage(file);
        }
    }
}
