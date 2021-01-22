using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebuygulamaVize1.Models
{
    public class Sebze
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Kg { get; set; }


        public static List<Sebze> sebzeListe = new List<Sebze>
        {
                 new Sebze
             {
                 Id=1,
                 Ad="Ispanak",
                 Kg="100",
             },
                  new Sebze
             {
                 Id=2,
                 Ad="Kabak",
                 Kg="65",
             },
                   new Sebze
             {
                 Id=3,
                 Ad="Patlıcan",
                 Kg="149",
             }
        };
    }
}