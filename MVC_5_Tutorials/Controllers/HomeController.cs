using MVC_5_Tutorials.Models;
using System.Web.Mvc;


namespace MVC_5_Tutorials.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var cars = HelloModel.GetCar();

            ViewBag.ValueFromIndexController = "12";

            return View(cars);
        }
    }
}