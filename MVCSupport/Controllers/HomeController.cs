using MVCSupport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSupport.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult serial(string serialNumber)
        {
            string serial = "ASP.NETMVC123";
            if (serialNumber == "lower")
            {
                return Content(serial.ToLower());
            }
            else
                return Content(serial);
        }
        public ActionResult About()
        {
            SelectListItem a = new SelectListItem() { Value = "1", Text = "2" }; new List<SelectListItem>() { a, a };
            ViewData["client"] =null ;
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            using (EFDbContext db = new EFDbContext())
            {db.Database.
                var m = db.Products.ToList();
                return View(m);
            }
            //List<WebGrease.Css.ImageAssemblyAnalysis.LogModel.ImageAssemblyAnalysisLog> log;
            //= RunnerLog.GetLogsFromDatabase()
            //WebGrease.Css.ImageAssemblyAnalysis.LogModel
            //RunnerLog.GetLogsFromDatabase()
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}