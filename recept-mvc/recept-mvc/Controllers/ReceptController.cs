using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Recept.Controllers
{
    public class ReceptController : Controller
    {

        public ActionResult Detail()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Sunday)
            {

                return new RedirectResult("/");
            }

            return Content("Hellow world!");
        }
    }
}