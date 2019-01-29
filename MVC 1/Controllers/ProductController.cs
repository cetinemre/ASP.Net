using System;
using MVC_1.Models;
using System.Linq;
using System.Web.Mvc;

namespace MVC_1.Controllers
{
    public class ProductController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            var data = new NorthwindSabahEntities()
                .Products
                .OrderBy(x => x.ProductName)
                .ToList();
            return View(data);
        }
        public ActionResult Detail(int? id)
        {
            if (id == null) return RedirectToAction("Index");

            var data = new NorthwindSabahEntities().Products.Find(id.Value);
            if (data == null) RedirectToAction("Index");

            return View(data);
        }
        [HttpPost]
        public ActionResult Add(Products products)
        {
            try
            {
                var db = new NorthwindSabahEntities();
                db.Products.Add(products);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int? id)
        {
            var db = new NorthwindSabahEntities();
            try
            {
                var products = db.Products.Find(id.GetValueOrDefault());
                if (products == null) return RedirectToAction("Index");

                db.Products.Remove(products);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Update(int? id)
        {
            if (id == null)
                return RedirectToAction("Index", "Product");

            try
            {
                var data = new NorthwindSabahEntities().Products.Find(id.Value);
                if (data == null)
                    return RedirectToAction("Index", "Product");

                return View(data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Product");
            }
        }

        [HttpPost]
        public ActionResult Update(Products model)
        {
            try
            {
                var db = new NorthwindSabahEntities();
                var data = db.Products.Find(model.ProductID);

                if (data == null)
                    return RedirectToAction("Index");

                data.ProductName = model.ProductName;
                data.UnitsInStock = model.UnitsInStock;
                db.SaveChanges();
                ViewBag.Message = "<span class='text text-success'>Update Successfully</span>";
                return View(data);
            }
            catch (Exception ex)
            {
                ViewBag.Message = $"<span class='text text-danger'>Update Error {ex.Message}</span>";
                return View(model);
            }
        }

        public JsonResult Products()
        {
            var products = new NorthwindSabahEntities().Products.Select(x => new
            {
                x.ProductName,
                x.ProductID,
                x.UnitsInStock
            }).ToList();

            return Json(products, JsonRequestBehavior.AllowGet);
        }
    }
}