using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VogeltellersASP.Models.Data;
using VogeltellersASP.Models.Logic;

namespace VogeltellersASP.Controllers
{
    public class HomeController : Controller
    {
        IContext context;
        MSSQLContext SQLContext;

        public HomeController()
        {
            SQLContext = new MSSQLContext(context);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Project()
        {
            return View();
        }
    }
}