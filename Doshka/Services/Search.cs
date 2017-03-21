using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Doshka.Models;

namespace Doshka.Services
{
    public static class Search
    {
        private static readonly ApplicationDbContext Db = new ApplicationDbContext();

        public static List<Ad> GetAds(string searchString)
        {
            string[] searchWords = searchString.Split(' ');
            var pages = Db.Ads.ToList();
            IEnumerable<Ad> ads = new List<Ad>();
            foreach (var item in searchWords)
            {
                ads = from i in pages
                    where i.Title.Contains(item) || i.Description.Contains(item)
                                      select i;
            }
            return ads.ToList();
        }
    }
}