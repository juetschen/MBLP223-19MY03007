using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebuygulamaVize1.Controllers
{
    public class sebzeController : Controller
    {

        public ActionResult Liste1()
        {
            return View(Models.Sebze.sebzeListe);
        }

        public ActionResult Edit(int Id)
        {
            var aa = Models.Sebze.sebzeListe.Where(e => e.Id == Id).FirstOrDefault();
            return View(aa);
        }

        [HttpPost]

        public ActionResult Edit(Models.Sebze bb)
        {
            var aa = Models.Sebze.sebzeListe.Where(e => e.Id == bb.Id).FirstOrDefault();
            aa.Id = bb.Id;
            aa.Ad = bb.Ad;
            aa.Kg = bb.Kg;
            return RedirectToAction("Liste1");
        }

        public ActionResult Delete(int Id)

        {

            var aa = Models.Sebze.sebzeListe.Where(x => x.Id == Id).FirstOrDefault();

            return View(aa);

        }

        [HttpPost]
        public ActionResult Delete(Models.Sebze bb)

        {

            var aa = Models.Sebze.sebzeListe.Where(x => x.Id == bb.Id).FirstOrDefault();
            Models.Sebze.sebzeListe.Remove(aa);
            return RedirectToAction("Liste1");

        }

        public ActionResult Create()

        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Models.Sebze cc)
        {

            Models.Sebze.sebzeListe.Add(cc);
            return RedirectToAction("Liste1");

        }

            
    }
}