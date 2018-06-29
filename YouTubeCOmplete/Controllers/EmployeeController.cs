using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YouTubeCOmplete.Models;

namespace YouTubeCOmplete.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            Employee emp = new Employee()
            {
                id = 1,
                Name ="Akhilesh Kumar Sahu",
                age=12,
                city="Mandla"
            };


            return View();
        }
    }
}