using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Common.Http
{
    public static class HttpHelper
    {
        public static string GetHtml(string uri)
        {
            var request = HttpWebRequest.Create(uri);
            var response = request.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());
            var result = streamReader.ReadToEnd();
            return result;
        }
    }
}
