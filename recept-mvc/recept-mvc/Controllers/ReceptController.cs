using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Receptbok.Models;

namespace Receptbok.Controllers
{
    public class ReceptController : Controller
    {

        public ActionResult Detail()
        {
            Recept bolognese = new Recept();



            ViewBag.Title = "Hello from our Detail view";
            bolognese.Rubrik = "Spaghetti Bolognese";
            bolognese.ReceptID = 150;
            bolognese.BeskrivningHTML = "<em>Best bolognese recipe!</em> Takes a long time but worth it. Veal easily substituted with more of other meats. Also veal Demi grace can be eliminated or substitute a beef broth & roux combo";
            bolognese.Ingredienser = new string[5]
            {

                "Tomat",
                "Basilika",
                "Tofu",
                "Spaghetti",
                "Oregano"

            };
            


            return View(bolognese);
        }
    }
}