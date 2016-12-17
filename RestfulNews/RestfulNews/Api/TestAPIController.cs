using RestfulNews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestfulNews.Api
{
    /// <summary>
    /// RESTful API/WEB API 测试类
    /// 2016年12月17日12:32:38
    /// </summary>
    public class TestAPIController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<News> Get()
        {
            return new News[] {
                new News{ Id="1",Title="no1news",Content="这是第一条新闻测试",CreateTime=DateTime.Now,EditTime=DateTime.Now },
                new News{ Id="2",Title="no2news",Content="这是第2条新闻测试",CreateTime=DateTime.Now,EditTime=DateTime.Now },
                new News{ Id="3",Title="no3news",Content="这是第3条新闻测试",CreateTime=DateTime.Now,EditTime=DateTime.Now }
            };
        }

        // GET api/<controller>/5
        public News Get(int id)
        {
            return new News { Id = "4", Title = "no4news", Content = "这是第4条新闻测试", CreateTime = DateTime.Now, EditTime = DateTime.Now };
        }

        // POST api/<controller>
        public void Post([FromBody]News value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]News value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}