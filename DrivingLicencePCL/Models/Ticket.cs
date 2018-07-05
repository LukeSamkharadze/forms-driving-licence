using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace DrivingLicencePCL.Models
{
    public class Ticket
    {
        [JsonProperty("answers")]
        public string Answers { get; set; }

        [JsonProperty("coeficient")]
        public string Coeficient { get; set; }

        [JsonProperty("correct_answer")]
        public long CorrectAnswer { get; set; }

        [JsonProperty("desc")]
        public string Desc { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("question")]
        public string Question { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("topic")]
        public long Topic { get; set; }
    }
}
