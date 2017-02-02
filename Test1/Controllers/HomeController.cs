using DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            using (MySchoolEntities db = new MySchoolEntities())
            {
                return View(db.Student.ToList());
            }
          
        }
    }
}