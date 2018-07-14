using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

using DrivingLicencePCL.Models;

namespace DrivingLicencePCL.Services
{
    public static class C_DownloadTicketsAndTopics
    {
        public static List<C_Ticket> GetTicketList()
        {
            return JsonConvert.DeserializeObject<List<C_Ticket>>(DrivingLicenceServerPCL.Services.Services.DownloadJson("Tickets.json"));
        }

        public static List<C_Topic> GetTopicList()
        {
            return JsonConvert.DeserializeObject<List<C_Topic>>(DrivingLicenceServerPCL.Services.Services.DownloadJson("topics.json"));
        }
    }
}
