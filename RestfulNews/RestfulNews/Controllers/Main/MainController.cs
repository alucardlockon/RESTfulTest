using RestfulNews.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestfulNews.Controllers.Main
{
    public class MainController : Controller
    {
        MainDbContext db = new MainDbContext();
        // GET: Main
        public ActionResult Index()
        {
            return View(db.Newses.ToList());
        }

        // GET: List
        public ActionResult NewsList()
        {
            return View();
        }

        // GET: Main/Details/5
        public ActionResult Details(int id)
        {
            var news = db.Newses.Find(id);
            if (news==null)
            {
                return HttpNotFound();
            }
            return View(news);
        }

        // GET: Main/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Main/Create
        [HttpPost]
        public ActionResult Create(News news)
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
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Main/Edit/5
        public ActionResult Edit(int id)
        {
            var news = db.Newses.Find(id);
            if (news == null)
            {
                return HttpNotFound();
            }
            return View(news);
        }

        // POST: Main/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, News news)
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
                return RedirectToAction("Index");
            }
            catch(Exception e)
            {
                return View();
            }
        }

        // GET: Main/Delete/5
        public ActionResult Delete(int id)
        {
            var news = db.Newses.Find(id);
            if (news == null)
            {
                return HttpNotFound();
            }
            return View(news);
        }

        // POST: Main/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, News news2)
        {
            try
            {
                var news = db.Newses.Find(id);
                if (news == null)
                    return HttpNotFound();
                db.Newses.Remove(news);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
