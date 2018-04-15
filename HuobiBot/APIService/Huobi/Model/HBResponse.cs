using System;
using System.Collections.Generic;
using System.Text;

namespace APIService.Huobi.Model
{
    public class HBResponse<T> where T : new()
    {
        public string Status { get; set; }
        public T Data { get; set; }
    }
}
