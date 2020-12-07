using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebuygulamaVize1.Models
{
    public class Meyve
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Kg { get; set; }


        public static List<Meyve> meyveListe = new List<Meyve>
        {
                 new Meyve
             {
                 Id=1,
                 Ad="Elma",
                 Kg="100",
             },
                  new Meyve
             {
                 Id=2,
                 Ad="Armut",
                 Kg="65",
             },
                   new Meyve
             {
                 Id=3,
                 Ad="Portakal",
                 Kg="149",
             }
        };
    }
}