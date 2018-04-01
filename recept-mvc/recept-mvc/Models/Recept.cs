using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace recept_mvc.Models
{
    public class Recept
    {
        public int ReceptID { get; set; }
        public string Rubrik { get; set; }
        public string BeskrivningHTML { get; set; }
        public Ingredienser[] Ingredienser { get; set; }
        public bool Favorit { get; set; }

        public string DisplayText
        {
            get { return Rubrik + " " + ReceptID; }
        }

       public string CoverImageFilename
       {
           get { return Rubrik.Replace(" ", "-").ToLower() + "-" + ReceptID.ToString();  }
       }
    }
}