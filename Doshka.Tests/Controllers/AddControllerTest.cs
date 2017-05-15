using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Doshka;
using Doshka.Controllers;

namespace Doshka.Tests.Controllers
{
    [TestClass]
    public class AdsControllerTest
    {
        [TestMethod]
        public void Index()
        {
            var controller = new AdsController();
            var result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void DeleteOutdatedAds()
        {
            var controller = new AdsController();
            var result = controller.DeleteOutdatedAds();
            Assert.AreEqual(new EmptyResult(), result);
        }


        [TestMethod]
        public void Delete()
        {
            var controller = new AdsController();
            var result = controller.Delete(new Random().Next());
            Assert.AreNotEqual(
                new EmptyResult(), 
                new HttpStatusCodeResult(HttpStatusCode.BadRequest));
        }
    }
}
