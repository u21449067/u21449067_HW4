using HW4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW4.Controllers
{
    public class HomeController : Controller
    {
        public static List<Recyclables> recyclables = new List<Recyclables>();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult HowItWorks()
        {
            ViewBag.Message = "This does a thing";
            //recyclables.Add(new Glass(new DropOffPoint("Pretoria", "123 Test", "Glass Place"), "Glass"));
            //recyclables.Add(new Plastic(new DropOffPoint("Cape Town", "456 Test", "Platic Land"), "Plastic"));
            //recyclables.Add(new Paper(new DropOffPoint("Durban", "789 Test", "Ronnie Recycling"), "Paper"));
            return View(recyclables);
        }

        public ActionResult RecycleYourself()
        {
            ViewBag.Message = "Recycle Yourself";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AddDropoff()
        {
            ViewBag.Message = "This is the Add Dropoff Page";

            return View();
        }

        public ActionResult Admin()
        {
            ViewBag.Message = "This is the Admin Page";

            return View();
        }

        [HttpPost]
        public ActionResult AddDropoff(string dropOffName, string city, string address, string recyclableType)
        {
            //TODO: Figure out how to show popup that says successfully added company
            switch (recyclableType)
            {
                case "1":
                    recyclables.Add(new Glass(new DropOffPoint(city, address, dropOffName), recyclableType));
                    break;
                case "2":
                    recyclables.Add(new Paper(new DropOffPoint(city, address, dropOffName), recyclableType));
                    break;
                case "3":
                    recyclables.Add(new Aluminium(new DropOffPoint(city, address, dropOffName), recyclableType));
                    break;
                case "4":
                    recyclables.Add(new Plastic(new DropOffPoint(city, address, dropOffName), recyclableType));
                    break;
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult deleteDropOff(string companyName)
        {
            //TODO: Figure out how to show popup that says successfully deleted company
            int indexToRemove = 0;
            for(int i = 0; i < recyclables.Count; i++)
            {
                if (recyclables[i].DropoffPoint.Name.Equals(companyName))
                {
                    indexToRemove = i;
                }
            }

            recyclables.RemoveAt(indexToRemove);
            return RedirectToAction("Index");
        }

        //[HttpPost]
        //public ActionResult searchCity(String searchCity)
        //{
        //    List<Recyclables> tempList = new List<Recyclables>();

        //    foreach(Recyclables el in recyclables)
        //    {
        //        if (el.City == searchCity)
        //        {
        //            tempList.Add(el);
        //        }
        //    }

        //    return View(tempList);
        //}
    }
}