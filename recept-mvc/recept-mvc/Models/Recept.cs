using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Receptbok.Models
{
    public class Recept
    {
        public int ReceptID { get; set; }
        public string Rubrik { get; set; }
        public string BeskrivningHTML { get; set; }
        public string[] Ingredienser { get; set; }
        public bool Favorit { get; set; }

        public Recept()
        {
            
        }
        public Recept(int receptid, string receptrubrik)
        {
            ReceptID = receptid;
            Rubrik = receptrubrik;

        }

        public string DisplayText => Rubrik + " " + ReceptID;
    

       public string CoverImageFilename => Rubrik.Replace(" ", "-").ToLower() + "-" + ReceptID;
       
    }
}