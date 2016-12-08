using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myFirstMVCProject.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //public string Index(string id, string name)
        //{
        //    return "ID: " + id +" <br />Name: " + Request.QueryString["name"];
        //}

        public ActionResult Index() // Send list of countries added to view page
        {
            //    //Sending information usind Viewbag
            //    //ViewBag.Contries = new List<string>()
            //    //{
            //    //     "India",
            //    //     "Australia",
            //    //     "US",
            //    //     "UK"
            //    // };

            //    //Sending information usind ViewData
            ViewData["Contries"] = new List<string>()
            {
                 "India",
                 "Australia",
                 "US",
                 "UK"
             };
            //    //Both 'ViewData' & 'ViewBag' are not good methos to use for retriving data from controller 
            //    //as those doesn't provide compile time error - It will take you in trobule when you load your project on production and get error

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}