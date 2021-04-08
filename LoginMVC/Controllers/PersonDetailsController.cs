using LoginMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginMVC.Controllers
{
    public class PersonDetailsController : Controller
    {
        // GET: PersonDetails
        public ActionResult PersonData()
        {
            return View();
        }
        [HttpPost]
        public ActionResult View(Person person)
        {
            return View("About",person);
        }
    }
}