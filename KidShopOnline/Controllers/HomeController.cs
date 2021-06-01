using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidShopOnline.Entity;

namespace KidShopOnline.Controllers
{
    public class HomeController : Controller
    {
        DataContext db = new DataContext();
        public PartialViewResult Slider()
        {
            return PartialView(db.Products.Where(i => i.isApproved && i.Slider).Take(5).ToList());
        }
        // GET: Home
        
        public ActionResult Search(string q)
        {
            var p = db.Products.Where(i => i.isApproved == true);
            if (!string.IsNullOrEmpty(q))
            {
                p = p.Where(i => i.Name.Contains(q) || i.Description.Contains(q));
            }
            return View(p.ToList());
        }
        public ActionResult Index()
        {
            return View(db.Products.Where(i=>i.isHome&&i.isApproved).ToList());
        }
        public ActionResult ProductDetails(int id)
        {

            return View(db.Products.Where(i=>i.Id==id).FirstOrDefault());
        }
        public ActionResult Product()
        {

            return View(db.Products.ToList());
        }
        public ActionResult ProductList(int id)
        {
            return View(db.Products.Where(i=>i.CategoryId==id).ToList());
        }
    }
}