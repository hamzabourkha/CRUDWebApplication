using CRUDWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUDWebApplication.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetData()
        {
            List<Employee> empList = new List<Employee>();
            using (var context = new CRUDDBEntities1())
            {
                empList = context.Employee.ToList<Employee>();
            }

            return Json(new { data = empList }, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult AddOrEdit(int id=0)
        {
            return View(new Employee());
        }
        [HttpPost]
        public ActionResult AddOrEdit()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}