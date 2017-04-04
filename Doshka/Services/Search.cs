using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Doshka.Models;

namespace Doshka.Services
{
    public static class Search
    {
        private static readonly ApplicationDbContext Db = new ApplicationDbContext();

        public static List<Ad> GetAds(string searchString, string minPrice, string maxPrice, string type)
        {
            IEnumerable<Ad> ads = Db.Ads;
            if (!String.IsNullOrEmpty(searchString))
            {
                string[] searchWords = searchString.Split(' ');
                foreach (var item in searchWords)
                {
                    ads = from i in ads
                        where i.Title.Contains(item) || i.Description.Contains(item)
                        select i;
                }
            }
            if (!String.IsNullOrEmpty(minPrice))
            {
                ads = from i in ads
                    where i.Price > Convert.ToDecimal(minPrice)
                    select i;
            }
            if (!String.IsNullOrEmpty(maxPrice))
            {
                ads = from i in ads
                      where i.Price < Convert.ToDecimal(maxPrice)
                      select i;
            }
            if (!String.IsNullOrEmpty(type) && type == "Any")
            {
                ads = from i in ads
                      where i.Type == type
                      select i;
            }
            return ads.ToList();
        }
    }
}