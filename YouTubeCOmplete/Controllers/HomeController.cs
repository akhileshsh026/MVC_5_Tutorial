using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YouTubeCOmplete.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public List<string> Index()
        {
            return new List<string>()
            {
                "India",
                "US",
                "UK",
                "France"
            };

        }
    }
}