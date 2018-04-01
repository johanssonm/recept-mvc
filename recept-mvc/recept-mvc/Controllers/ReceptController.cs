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
            ViewBag.Title = "Hello from or Detail view";
            ViewBag.PageTitle = "Spaghetti Bolognese";
            ViewBag.ReceptID = 150;
            ViewBag.Description = "<em>Best bolognese recipe!</em> Takes a long time but worth it. Veal easily substituted with more of other meats. Also veal Demi grace can be eliminated or substitute a beef broth & roux combo";
            ViewBag.Ingredients = new string[]
            {
                "1/2 pound ground veal",
                "freshly ground pepper",
                "salt",
                "grated nutmeg (Freshly, to taste)",
                "1/2 cup dry white wine "
            };

            return View();
        }
    }
}