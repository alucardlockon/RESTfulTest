using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;

namespace RestfulNews.Tests.normal
{
    [TestClass]
    public class NormalTest
    {
        [TestMethod]
        public void TestDateTime()
        {
            string rqStr = "1212";
            string yxq_val = "yym".Replace("m", "M");
            DateTime datetime;
            //检测日期格式是否正确
            if(DateTime.TryParseExact(rqStr,yxq_val, CultureInfo.InvariantCulture, DateTimeStyles.None,out datetime))
            //if (DateTime.TryParse(rqStr, out datetime))
            //if (DateTime.TryParse(rqStr, info, DateTimeStyles.None, out datetime))
            {
            }else
            {
                Assert.Fail();
            }
        }
    }
}
