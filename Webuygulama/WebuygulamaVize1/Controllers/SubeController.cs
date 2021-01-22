using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace WebuygulamaVize1.Controllers
{
    public class SubeController : Controller
    {
        // GET: Sube
        public ActionResult Index()
        {
            using (var session = NhibernateHelper.OpenSession())
            {
                var subes = session.Query<Models.Sube>().Fetch(x => x.Subeler).ToList();
                return View(subes);
            }
        }

        public ActionResult Listele()
        {
            using (var session = NhibernateHelper.OpenSession())
            {
                var subes = session.Query<Models.Sube>().ToList();
                return View(subes);
            }
        }

        public ActionResult Yeni()
        {
            return View();
        }




        [HttpPost]
        public ActionResult Edit(Models.Sube sube)
        {
            using (var session = NhibernateHelper.OpenSession())
            {
                var subes = session.Query<Models.Sube>().FirstOrDefault(x => x.Sube_Id == sube.Sube_Id);
                subes.Sube_Ad = sube.Sube_Ad;
                subes.Sehir = sube .Sehir;
                session.SaveOrUpdate(subes);
                session.Flush();
                return RedirectToAction("/Index");
            }
        }
    }
}