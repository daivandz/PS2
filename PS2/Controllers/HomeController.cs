using PS2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PS2.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {          
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Menu()
        {
            return View(db.Menus.ToList());
        }

        // GET: Orders/Create
        public ActionResult Ordenar()
        {
            ViewBag.MenuId = (from p in db.Menus select p).ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Ordenar(Order order)
        {
            if (ModelState.IsValid)
            {
                Menu menu = db.Menus.Find(order.MenuId);
                decimal total = order.Quantity * menu.Price;
                order.Total = total;
                db.Orders.Add(order);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MenuId = new SelectList(db.Menus, "id", "Name", order.MenuId);
            return View(order);
        }
    }
}