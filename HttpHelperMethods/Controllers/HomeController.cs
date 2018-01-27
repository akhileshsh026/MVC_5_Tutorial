using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HttpHelperMethods.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {           

            var categories = new List<SelectListItem>
            {
                new SelectListItem { Text = "Classic" , Value = "C" },
                new SelectListItem { Text = "Stuff Recomands" , Value = "S"},
                new SelectListItem { Text = "Book Club Selection" , Value = "BC"},
                new SelectListItem { Text = "Most Popular" , Value = "MP"}
            };

            ViewBag.Categories = categories;

            return View();
        }
    }
}