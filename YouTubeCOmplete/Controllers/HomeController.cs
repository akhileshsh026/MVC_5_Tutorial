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
        public string Index(string id)
        {
            return id + Request.QueryString["name"];
        }
    }
}