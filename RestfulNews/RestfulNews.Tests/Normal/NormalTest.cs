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
            string rqStr = "16";
            string yxq_val = "yy".Replace("m", "M");
            DateTime datetime;
            //检测日期格式是否正确,根据可能的格式继续添加
            switch (yxq_val)
            {
                case "yyddd":
                    
                    break;
                case "dddyy":

                    break;
                default:
                    if (DateTime.TryParseExact(rqStr, yxq_val, CultureInfo.InvariantCulture, DateTimeStyles.None, out datetime))
                    //if (DateTime.TryParse(rqStr, out datetime))
                    //if (DateTime.TryParse(rqStr, info, DateTimeStyles.None, out datetime))
                    {
                    }
                    else
                    {
                        Assert.Fail();
                    }
                    break;
            }
        }
    }
}
