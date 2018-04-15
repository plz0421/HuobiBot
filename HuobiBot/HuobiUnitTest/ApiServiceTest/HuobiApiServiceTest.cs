using APIService.Huobi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace HuobiUnitTest.ApiService
{
    [TestClass]
    public class HuobiApiServiceTest
    {
        [TestMethod]
        public void GetTimeStampTest()
        {
            HuobiApiService huobiApiService = new HuobiApiService("eb7871cb-19b950c9-5ddcef77-e918c", "cf74030e-ba231ea8-ee5d6c1f-dd095");
            var timestamp = huobiApiService.GetAllAccount();
        }
    }
}
