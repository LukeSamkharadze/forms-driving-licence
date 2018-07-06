using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLicenceServerPCL.Services
{
    public static class Services
    {
        public static string path = $@"{Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\"))}DrivingLicenceServerPCL\";

        public static string DownloadJson(string file)
        {
            using (StreamReader streamReader = new StreamReader($@"{path}Jsons\{file}"))
            {
                return streamReader.ReadToEnd();
            }
        }

        public static string DownloadImage(string file)
        {
            return $@"{path}Images\{file}";
        }
    }
}
