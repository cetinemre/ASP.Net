using System;
using MVC_1.Models;
using System.Linq;
using System.Web.Mvc;

namespace MVC_1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            var data = new NorthwindSabahEntities()
                .Employees
                .OrderBy(x => x.FirstName)
                .ToList();
            return View(data);
        }
        public ActionResult Detail(int? id)
        {
            if (id == null) return RedirectToAction("Index");

            var data = new NorthwindSabahEntities().Employees.Find(id.Value);
            if (data == null) RedirectToAction("Index");

            return View(data);
        }
        [HttpPost]
        public ActionResult Add(Employees employees)
        {
            try
            {
                var db = new NorthwindSabahEntities();
                db.Employees.Add(employees);
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
                var employees = db.Employees.Find(id.GetValueOrDefault());
                if (employees == null) return RedirectToAction("Index");

                db.Employees.Remove(employees);
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
                return RedirectToAction("Index", "Employee");

            try
            {
                var data = new NorthwindSabahEntities().Employees.Find(id.Value);
                if (data == null)
                    return RedirectToAction("Index", "Employee");

                return View(data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Employee");
            }
        }

        [HttpPost]
        public ActionResult Update(Employees model)
        {
            try
            {
                var db = new NorthwindSabahEntities();
                var data = db.Employees.Find(model.EmployeeID);

                if (data == null)
                    return RedirectToAction("Index");

                data.FirstName = model.FirstName;
                data.LastName = model.LastName;
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

        public JsonResult Employees()
        {
            var employees = new NorthwindSabahEntities().Employees.Select(x => new
            {
                x.FirstName,
                x.EmployeeID,
                x.LastName
            }).ToList();

            return Json(employees, JsonRequestBehavior.AllowGet);
        }
    }
}