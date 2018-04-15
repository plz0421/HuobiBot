using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public static class Utils
    {
        public static long GetUnixTimeStamp()
        {
            System.DateTime startTime = new System.DateTime(1970, 1, 1);
            return (long)(DateTime.Now - startTime).Milliseconds;
        }
    }
}
