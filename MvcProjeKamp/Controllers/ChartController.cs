using MvcProjeKamp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKamp.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CategoryChart()
        {
            return Json(BlogList(), JsonRequestBehavior.AllowGet);
        }

        public List<CategoryClass> BlogList()
        {
            List<CategoryClass> ct= new List<CategoryClass>();
            ct.Add(new CategoryClass()
            {
                CategoryName = "kitap",
                CategoryCount = 8
            });
            ct.Add(new CategoryClass()
            {
                CategoryName="Eğitim",
                CategoryCount= 4
            });
            ct.Add(new CategoryClass()
            {
                CategoryName = "yazılım",
                CategoryCount = 7
            });
            ct.Add(new CategoryClass()
            {
                CategoryName = "spor",
                CategoryCount = 1
            });
            return ct;
        }
    }
}