using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestfulNews.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestfulNews.Commons.Tests
{
    [TestClass()]
    public class RssFeedHelperTests
    {
        [TestMethod()]
        public void ReadRssTest()
        {
            string a=RssFeedHelper.ReadRss();
            Console.WriteLine(a);
        }
    }
}