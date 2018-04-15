using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace APIService.Huobi.Model
{
    public class Account
    {
        public long Id { get; set; }
        public string Type { get; set; }
        public string State { get; set; }
        [JsonProperty(PropertyName = "user-id")]
        public long UserId { get; set; }
    }
}
