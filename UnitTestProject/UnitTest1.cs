using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication_Razor.Models;
using WebApplication_Razor.Controllers;
using System.Web.Mvc;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestUserListView()
        {
            var controller = new HomeController();
            var result = controller.UserList() as PartialViewResult;
            Assert.AreEqual("UserList", result.ViewName);
        }

        [TestMethod]
        public void TestCallToActionView()
        {
            var controller = new HomeController();
            var result = controller.CallToAction(null, null) as PartialViewResult;
            Assert.AreEqual("CallToAction", result.ViewName);
        }

        [TestMethod]
        public void TestCallToActionViewData()
        {
            string uri = "http://www.thoughtworks.com";
            string imageUri = "https://www.diversecitycareers.com/media/diversecitycareers/images/thoughtworks.jpg";
            var controller = new HomeController();
            var result = controller.CallToAction(uri, imageUri) as PartialViewResult;
            var ctaModel = (CTAModel)result.ViewData.Model;
            Assert.AreEqual(uri, ctaModel.Uri);
            Assert.AreEqual(imageUri, ctaModel.ImageUri);
        }
    }
}
