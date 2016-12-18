using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spring.Context;
using Spring.Context.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestfulNews.Commons
{
    [TestClass]
    public class SpringHelper
    {
        [TestMethod]
        public static void test()
        {
            //控制权没有反转
            //IUserInfoDal infoDal = new EFUserInfoDal();

            //Spring.Net 创建实例的方式转为容器帮我们创建
            //创建spring容器上下文
            IApplicationContext ctx = ContextRegistry.GetContext();
            //通过容器创建对象
            //IUserInfoDal efDal = ctx.GetObject("UserInfoDal") as IUserInfoDal;
            //efDal.Show();
            //Console.ReadKey();
        }
    }
}