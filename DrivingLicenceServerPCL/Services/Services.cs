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
        public static string path = $@"{Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\"))}DrivingLicenceServerPCL\Jsons\";

        public static string Download(string file)
        {
            using (StreamReader streamReader = new StreamReader($"{path}{file}"))
            {
                //Console.OutputEncoding = System.Text.Encoding.UTF8;
                //Console.WriteLine(streamReader.ReadToEnd());
                return streamReader.ReadToEnd();
            }
        }
    }
}
