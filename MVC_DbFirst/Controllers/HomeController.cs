using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL.Repository;
using DAL;

namespace MVC_DbFirst.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ItemRepository itemRepo = new ItemRepository();
            List<Item> items = new List<Item>();

            items = itemRepo.getItems();
            ViewBag.items = items;
            ViewBag.count = items.Count;

            return View("Index", ViewBag);
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
    }
}