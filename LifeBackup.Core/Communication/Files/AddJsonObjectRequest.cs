using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LifeBackup.Core.Communication.Files
{
    public class AddJsonObjectRequest
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }
        [JsonProperty("timesent")]
        public DateTime TimeSent { get; set; }
        [JsonProperty("data")]
        public string Data { get; set; }
    }
}
