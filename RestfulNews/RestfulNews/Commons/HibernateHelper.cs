using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using RestfulNews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestfulNews.Commons
{
    [TestClass()]
    public class HibernateHelper
    {
        public static void Test()
        {
            var cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(typeof(Product).Assembly);

            new SchemaExport(cfg).Execute(false, true,
                false);
        }

        private ISessionFactory _sessionFactory;
        private Configuration _configuration;
        [TestMethod()]
        public void TestFixtureSetUp()
        {
            _configuration = new Configuration();
            _configuration.Configure();
            _configuration.AddAssembly(typeof(Product).Assembly);
            _sessionFactory = _configuration.BuildSessionFactory();
        }
        [TestMethod()]
        public void Add()
        {
            TestFixtureSetUp();
            Product product = new Product();
            product.Name = "123";
            using (ISession session = _sessionFactory.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(product);
                transaction.Commit();
            }
        }

    }
}