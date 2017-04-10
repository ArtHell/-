using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ScheduledWorker
{
    class Program
    {
        private static readonly HttpClient Client = new HttpClient();

        static void Main(string[] args)
        {
            var response = Client.PostAsync("http://doshka.azurewebsites.net/Ads/DeleteOutdatedAds", null).Result;
        }
    }
}
