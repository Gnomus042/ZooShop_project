using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZooDataLibrary;
using ZooWeb.Models;

namespace ZooWeb.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order

        ZooDataLibrary.ZooShopEntities ctx = new ZooShopEntities();
        static OrdersFilter filter;

        public ActionResult OrdersTable()
        {
            SelectList clients = new SelectList(ctx.Clients.ToList(), "Id", "Name");
            this.ViewBag.Clients = clients;
            if (filter==null||filter.useClient==false)
            {
                filter = new OrdersFilter();
                filter.client = 1;
                filter.useClient = false;
                ViewBag.filter = filter;
                return View(ctx.Orders.ToList());
            }
            else
            {
                ViewBag.filter = filter;
                List<Orders> list = (from q in ctx.Orders where q.Id_client == filter.client select q).ToList();
                return View(list);
            }
        }

        [HttpGet]
        public ActionResult Edit(int id = 0)
        {
            SelectList products = new SelectList(ctx.Products.ToList(), "Id", "Name");
            this.ViewBag.Products = products;

            SelectList clients = new SelectList(ctx.Clients.ToList(), "Id", "Name");
            this.ViewBag.Clients = clients;

            SelectList status = new SelectList(ctx.Status.ToList(), "Id", "Name");
            this.ViewBag.Status = status;

            Orders order = (from q in ctx.Orders where q.id == id select q).FirstOrDefault();
            return View(order);
        }

        [HttpPost]
        public ActionResult Edit(Orders order)
        {
            Orders res = (from q in ctx.Orders where q.id == order.id select q).FirstOrDefault();
            res.Id_client = order.Id_client;
            res.Id_prod = order.Id_prod;
            res.Status = order.Status;
            ctx.SaveChanges();
            return RedirectToAction("OrdersTable");
        }

        public ActionResult Delete(int id = 0)
        {
            Orders order = (from q in ctx.Orders where q.id == id select q).FirstOrDefault();
            ctx.Orders.Remove(order);
            ctx.SaveChanges();
            return RedirectToAction("OrdersTable");
        }


        [HttpGet]
        public ActionResult Create()
        {
            SelectList products = new SelectList(ctx.Products.ToList(), "Id", "Name");
            this.ViewBag.Products = products;

            SelectList clients = new SelectList(ctx.Clients.ToList(), "Id", "Name");
            this.ViewBag.Clients = clients;

            SelectList status = new SelectList(ctx.Status.ToList(), "Id", "Name");
            this.ViewBag.Status = status;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Orders order)
        {
            ctx.Orders.Add(order);
            ctx.SaveChanges();
            return RedirectToAction("OrdersTable");
        }

        [HttpPost]
        public ActionResult Filter(OrdersFilter model)
        {
            filter.client = model.client;
            filter.useClient = model.useClient;
            return RedirectToAction("OrdersTable");
        }
    }
}