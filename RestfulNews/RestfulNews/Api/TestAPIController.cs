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
        News[] newsArr= new News[] {
                new News{ Id="1",Title="no1news",Content="这是第1条新闻测试",CreateTime=DateTime.Now,EditTime=DateTime.Now },
                new News{ Id="2",Title="no2news",Content="这是第2条新闻测试",CreateTime=DateTime.Now,EditTime=DateTime.Now },
                new News{ Id="3",Title="no3news",Content="这是第3条新闻测试",CreateTime=DateTime.Now,EditTime=DateTime.Now }
            };
        // GET api/<controller>
        public IEnumerable<News> Get()
        {
            return newsArr;
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(string id)
        {
            var news = newsArr.FirstOrDefault((n)=>n.Id == id);
            if (news == null)
            {
                return NotFound();
            }
            return Ok(news);
        }

        // POST api/<controller>
        public void Post([FromBody]News news)
        {
            if (ModelState.IsValid)
            {
                
            }
        }

        // PUT api/<controller>/5
        public void Put(string id, [FromBody]News value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(string id)
        {
        }
    }
}