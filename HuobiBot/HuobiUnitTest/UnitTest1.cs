using Common.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HuobiUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = HttpHelper.GetHtml("https://www.baidu.com");
        }
    }
}
