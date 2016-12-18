using RestfulNews.Models;
using SimpleFeedReader;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

/// <summary>
/// RSS新闻读取
/// </summary>
namespace RestfulNews.Commons
{
    public static class RssFeedHelper
    {
        public static List<FeedItem> ReadRss(string url, int retCount = 100)
        {
            FeedReader reader = new FeedReader();
            //"http://www.ruanyifeng.com/blog/atom.xml"
            List<FeedItem> items = (List<FeedItem>)reader.RetrieveFeed(url);
            List<FeedItem> retList = new List<FeedItem>();
            if (retCount >= items.Count) retCount = items.Count;
            for (int i = 0; i < retCount; i++)
            {
                retList.Add(items[i]);
            }

            return retList;
        }

        public static List<News> ReadRssToNews(string url,int retCount=100)
        {
            List<News> newsList = new List<News>();
            FeedReader reader = new FeedReader();
            List<FeedItem> items = (List<FeedItem>)reader.RetrieveFeed(url);
            List<FeedItem> retList = new List<FeedItem>();
            if (retCount >= items.Count) retCount = items.Count;
            for (int i = 0; i < retCount; i++)
            {
                retList.Add(items[i]);
            }

            foreach (FeedItem item in retList)
            {
                News news = new News();
                news.Title = item.Title;
                news.BaseUrl = item.Uri.ToString();
                news.Content = item.Content;
                news.CreateTime = DateTime.Now;
                news.EditTime = DateTime.Now;
                newsList.Add(news);
            }
            return newsList;
        }

    }
}