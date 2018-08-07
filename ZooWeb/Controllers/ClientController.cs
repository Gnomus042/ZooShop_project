using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZooDataLibrary;

namespace ZooWeb.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client

        ZooDataLibrary.ZooShopEntities ctx = new ZooShopEntities();

        public ActionResult ClientsTable()
        {
            return View(ctx.Clients.ToList());
        }

        [HttpGet]
        public ActionResult Edit(int id = 0)
        {
            Clients client = (from q in ctx.Clients where q.Id == id select q).FirstOrDefault();
            return View(client);
        }

        [HttpPost]
        public ActionResult Edit(Clients clients)
        {
            Clients res = (from q in ctx.Clients where q.Id == clients.Id select q).FirstOrDefault();
            res.Name = clients.Name;
            res.Card = clients.Card;
            res.Tel = clients.Tel;
            ctx.SaveChanges();
            return RedirectToAction("ClientsTable");
        }

        public ActionResult Delete(int id = 0)
        {
            Clients client = (from q in ctx.Clients where q.Id == id select q).FirstOrDefault();
            if (client.Orders.Any())
            {
                ctx.Orders.RemoveRange(client.Orders);
                ctx.SaveChanges();
            }
            ctx.Clients.Remove(client);
            ctx.SaveChanges();
            return RedirectToAction("ClientsTable");
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Clients client)
        {
            ctx.Clients.Add(client);
            ctx.SaveChanges();
            return RedirectToAction("ClientsTable");
        }
    }
}