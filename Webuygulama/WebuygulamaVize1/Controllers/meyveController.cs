using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebuygulamaVize1.Controllers
{
    public class meyveController : Controller
    {
       

        public ActionResult Liste2()
        {
            return View(Models.Meyve.meyveListe);
        }

        public ActionResult Edit(int Id)
        {
            var aa = Models.Meyve.meyveListe.Where(e => e.Id == Id).FirstOrDefault();
            return View(aa);
        }

        [HttpPost]

        public ActionResult Edit(Models.Meyve bb)
        {
            var aa = Models.Meyve.meyveListe.Where(e => e.Id == bb.Id).FirstOrDefault();
            aa.Id = bb.Id;
            aa.Ad = bb.Ad;
            aa.Kg = bb.Kg;
            return RedirectToAction("Liste2");
        }

        public ActionResult Delete(int Id)

        {

            var aa = Models.Meyve.meyveListe.Where(x => x.Id == Id).FirstOrDefault();

            return View(aa);

        }

        [HttpPost]
        public ActionResult Delete(Models.Meyve bb)

        {

            var aa = Models.Meyve.meyveListe.Where(x => x.Id == bb.Id).FirstOrDefault();
            Models.Meyve.meyveListe.Remove(aa);
            return RedirectToAction("Liste2");

        }

       

        public ActionResult Create()

        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Models.Meyve cc)
        {

            Models.Meyve.meyveListe.Add(cc);
            return RedirectToAction("Liste2");

        }

    }
}