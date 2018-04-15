using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace APIService.Huobi.Model
{
    public class OrderPlaceRequest
    {
        [JsonProperty("account-id")]
        public string account_id { get; set; }
        public string amount { get; set; }
        public string price { get; set; }
        public string source { get; set; }
        public string symbol { get; set; }
        public string type { get; set; }
    }
}
