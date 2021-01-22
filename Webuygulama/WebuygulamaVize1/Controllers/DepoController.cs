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
    public class BankaController : Controller
    {
        // GET: Depo
        public ActionResult Index()
        {
            using (var session = NhibernateHelper.OpenSession())
            {
                var dpo1 = session.Query<Models.Depo>().Fetch(x => x.Subeler).ToList();
                return View(dpo1);
            }
        }

        public ActionResult Liste2()
        {
            using (var session = NhibernateHelper.OpenSession())
            {
                var depoo = session.Query<Models.Depo>().ToList();
                return View(depoo);
            }
        }



        public ActionResult Edit(int id)
        {
            using (var session = NhibernateHelper.OpenSession())
            {
                var dpo = session.Query<Models.Depo>().FirstOrDefault(x => x.Id == id);
                return View(dpo);
            }
        }


        [HttpPost]
        public ActionResult Edit(Models.Depo banka)
        {
            using (var session = NhibernateHelper.OpenSession())
            {
                var dpo1 = session.Query<Models.Depo>().FirstOrDefault(x => x.Id == Depo.Id);
                dpo1.Ad = Depo.Ad;
                dpo1.Sehir = depo_Id.Sehir;
                session.SaveOrUpdate(dpo1);
                session.Flush();
                return RedirectToAction("/Index");
            }
        }
    }
}