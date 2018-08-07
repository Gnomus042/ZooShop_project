using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZooDataLibrary;
using ZooWeb.Models;

namespace ZooWeb.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product

        ZooDataLibrary.ZooShopEntities ctx = new ZooShopEntities();
        static FilterModel filter;

        public ActionResult ProductsTable()
        {
            if (filter==null)
            {
                filter = new FilterModel();
                ViewBag.Filter = filter;
            }
            else
            {
                ViewBag.Filter = filter;
            }
           
            SelectList animKinds = new SelectList(ctx.AnimalKinds.ToList(), "Id", "Name");
            this.ViewBag.AnimKinds = animKinds;

            SelectList productKinds = new SelectList(ctx.ProductKinds.ToList(), "Id", "Kind");
            this.ViewBag.ProductKinds = productKinds;
            return View(setFilter(filter));
        }

        [HttpGet]
        public ActionResult Edit(int id = 0)
        {
            SelectList animKinds = new SelectList(ctx.AnimalKinds.ToList(), "Id", "Name");
            this.ViewBag.AnimKinds = animKinds;

            SelectList productKinds = new SelectList(ctx.ProductKinds.ToList(), "Id", "Kind");
            this.ViewBag.ProductKinds = productKinds;
            Products product = (from q in ctx.Products where q.Id == id select q).FirstOrDefault();
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Products product)
        {
            Products res = (from q in ctx.Products where q.Id == product.Id select q).FirstOrDefault();
            res.Name = product.Name;
            res.Quantity = product.Quantity;
            res.Price = product.Price;
            res.Inf = product.Inf;
            res.Product_kind = product.Product_kind;
            res.Anim_kind = product.Anim_kind;
            ctx.SaveChanges();
            return RedirectToAction("ProductsTable");
        }

        public ActionResult Delete(int id = 0)
        {
            Products p = (from q in ctx.Products where q.Id == id select q).FirstOrDefault();
            if (p.Orders.Any())
            {
                ctx.Orders.RemoveRange(p.Orders);
                ctx.SaveChanges();
            }
            ctx.Products.Remove(p);
            ctx.SaveChanges();
            return RedirectToAction("ProductsTable");
        }


        [HttpGet]
        public ActionResult Create()
        {
            SelectList animKinds = new SelectList(ctx.AnimalKinds.ToList(), "Id", "Name");
            this.ViewBag.AnimKinds = animKinds;

            SelectList productKinds = new SelectList(ctx.ProductKinds.ToList(), "Id", "Kind");
            this.ViewBag.ProductKinds = productKinds;
            return View();
        }

        [HttpPost]
        public ActionResult Create (Products product)
        {
            ctx.Products.Add(product);
            ctx.SaveChanges();
            return RedirectToAction("ProductsTable");
        }

        [HttpPost]
        public ActionResult Filter(FilterModel model)
        {
            filter = model;
            return RedirectToAction("ProductsTable");
        }

        private List<Products> setFilter(FilterModel model)
        {
            var query = (from q in ctx.Products select q);
            if (model.Name.Trim() != "")
            {
                query = query.Where(q => q.Name.Contains(model.Name.Trim()));
            }
            if (model.UseQuantity)
            {
                query = query.Where(q => q.Quantity == model.Quantity);
            }
            if (model.UsePrice)
            {
                query = query.Where(q => q.Price <= model.PriceTo && q.Price >= model.PriceFrom);
            }
            if (model.UseAnimKind)
            {
                query = query.Where(q => q.Anim_kind == model.AnimKind);
            }
            if (model.UseProdKind)
            {
                query = query.Where(q => q.Product_kind == model.ProdKind);
            }
            return query.ToList();
        }
    }
}