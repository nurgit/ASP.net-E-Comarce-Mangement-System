using ASP.net_E_Comarce_Mangement_System.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.net_E_Comarce_Mangement_System.Controllers
{
    namespace OnlineShoppingStore.Controllers
    {
        public class HomeController : Controller
        {
            public ActionResult Index(string search)
            {
                HomeIndexViewModel model = new HomeIndexViewModel();
                return View(model.CreateModel(search));
            }

            public ActionResult About()
            {
                ViewBag.Message = "Your application description page.";

                return View();
            }

        }
    }
}