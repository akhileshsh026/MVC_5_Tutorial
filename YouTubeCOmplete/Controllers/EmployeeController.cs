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
        public ActionResult Details(int ID)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            Employee emp1= employeeContext.Employees.Single(emp => emp.Id == ID);


            return View(emp1);
        }
    }
}