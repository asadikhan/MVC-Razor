using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication_Razor.Models;


namespace WebApplication_Razor.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public virtual ActionResult UserList()
        {
            return PartialView("UserList", UserModelBAL.FetchUsers());
        }

        public virtual ActionResult CallToAction(string uri, string imageUri)
        {
            CTAModel ctaModel;

            if (!String.IsNullOrEmpty(uri) && !String.IsNullOrEmpty(imageUri))
            {
                ctaModel = new CTAModel(uri, imageUri);
            }
            else
            {
                ctaModel = new CTAModel("http://www.google.com", "https://www.google.ca/logos/doodles/2015/googles-new-logo-5078286822539264.2-hp.gif");
            }

            return PartialView("CallToAction", ctaModel);
        }

    }
}