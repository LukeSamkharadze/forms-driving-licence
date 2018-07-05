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
    public static class Services
    {
        public static List<Ticket> GetTicketList()
        {
            return JsonConvert.DeserializeObject<List<Ticket>>(DrivingLicenceServerPCL.Services.Services.Download("tickets.json"));
        }

        public static List<Topic> GetTopicList()
        {
            return JsonConvert.DeserializeObject<List<Topic>>(DrivingLicenceServerPCL.Services.Services.Download("topics.json"));
        }
    }
}
