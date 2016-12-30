using RestfulNews.Controllers.Main;
using RestfulNews.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        MainDbContext db = new MainDbContext();
        News[] newsArr= new News[] {
                new News{ Id=1,Title="no1news",Content="这是第1条新闻测试",CreateTime=DateTime.Now,EditTime=DateTime.Now },
                new News{ Id=3,Title="no3news",Content="这是第3条新闻测试",CreateTime=DateTime.Now,EditTime=DateTime.Now },
                new News{ Id=2,Title="no2news",Content="这是第2条新闻测试",CreateTime=DateTime.Now,EditTime=DateTime.Now }
                
            };
        // GET api/<controller>
        public IEnumerable<News> Get()
        {
            //return newsArr;
            return db.Newses;
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            //var news = newsArr.FirstOrDefault((n)=>n.Id == id);
            var news = db.Newses.Find(id);
            if (news == null)
            {
                return NotFound();
            }
            return Ok(news);
        }

        // POST api/<controller>
        public void Post([FromBody]News news)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    news.CreateTime = DateTime.Now;
                    news.EditTime = DateTime.Now;
                    db.Newses.Add(news);
                    db.SaveChanges();
                }
            }
            catch
            {
            }
        }

        // PUT api/<controller>/5
        public void Put(string id, [FromBody]News news)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    news.EditTime = DateTime.Now;
                    db.Entry(news).State = EntityState.Modified;
                    db.Entry(news).Property(m => m.CreateTime).IsModified = false;
                    db.SaveChanges();
                }
            }
            catch
            {
            }
        }

        // DELETE api/<controller>/5
        public void Delete(string id)
        {
            try
            {
                var news = db.Newses.Find(id);
                if (news == null) return;
                db.Newses.Remove(news);
                db.SaveChanges();
            }
            catch
            {
            }
        }
    }
}