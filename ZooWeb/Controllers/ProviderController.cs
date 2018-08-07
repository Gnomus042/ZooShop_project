using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZooDataLibrary;

namespace ZooWeb.Controllers
{
    public class ProviderController : Controller
    {
        // GET: Provider

        ZooDataLibrary.ZooShopEntities ctx = new ZooShopEntities();

        public ActionResult ProvidersTable()
        {
            return View(ctx.Providers.ToList());
        }

        [HttpGet]
        public ActionResult Edit(int id = 0)
        {
            SelectList citys = new SelectList(ctx.Citys.ToList(), "Id", "Name");
            this.ViewBag.Citys = citys;

            Providers provider = (from q in ctx.Providers where q.Id == id select q).FirstOrDefault();
            return View(provider);
        }

        [HttpPost]
        public ActionResult Edit(Providers provider)
        {
            Providers res = (from q in ctx.Providers where q.Id == provider.Id select q).FirstOrDefault();
            res.Name = provider.Name;
            res.City = provider.City;
            ctx.SaveChanges();
            return RedirectToAction("ProvidersTable");
        }

        public ActionResult Delete(int id = 0)
        {
            Providers p = (from q in ctx.Providers where q.Id == id select q).FirstOrDefault();
            ctx.Providers.Remove(p);
            ctx.SaveChanges();
            return RedirectToAction("ProvidersTable");
        }

        [HttpGet]
        public ActionResult Create()
        {
            SelectList citys = new SelectList(ctx.Citys.ToList(), "Id", "Name");
            this.ViewBag.Citys = citys;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Providers provider)
        {
            ctx.Providers.Add(provider);
            ctx.SaveChanges();
            return RedirectToAction("ProvidersTable");
        }
    }
}