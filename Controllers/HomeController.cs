using Practical8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practical8.Controllers
{
    public class HomeController : Controller
    {
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

        public ActionResult ShapeSellection()
        {
          
            return View();
        }

        public ActionResult Rectangle()
        {
            return View();
        }

        public ActionResult Ellipse()
        {
            return View();
        }

        public ActionResult Triangle()
        {
            return View();
        }


        public ActionResult AddRectangle(Rectangle r)
        {
            shapes.Add(r);
            return RedirectToAction("Display");
        }

        public ActionResult AddEllipse(Ellipse e)
        {
            shapes.Add(e);
            return RedirectToAction("Display");
        }

        public ActionResult AddTriangle(Triangle t)
        {
            shapes.Add(t);
            return RedirectToAction("Display");
        }



        public static List<Shape> shapes = new List<Shape>();
        public ActionResult Display()
        {
            return View(shapes);
        }

    }
}