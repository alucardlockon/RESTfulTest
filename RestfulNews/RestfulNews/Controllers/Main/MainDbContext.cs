using RestfulNews.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestfulNews.Controllers.Main
{
    public class MainDbContext:DbContext
    {
        public DbSet<News> Newses { get; set; }
    }
}