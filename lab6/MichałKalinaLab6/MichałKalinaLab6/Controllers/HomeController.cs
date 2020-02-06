using MichałKalinaLab6.Models;
using MichałKalinaLab6.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MichałKalinaLab6.Controllers
{
    public class HomeController : Controller
    {
        //POLACZENIE Z BAZA DANYCH
        CarsAppDbEntities database = new CarsAppDbEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult InterestingLinks()
        {
            return View();
        }
        public ActionResult GetAllCars()
        {
            List<Car> allCars = database.Car.ToList();

            List<CarVM> viewCars = new List<CarVM>();
            foreach (var car in allCars)
            {
                CarVM viewCar = new CarVM(car.Model, car.Manufacturer, Convert.ToInt32(car.Price), car.Photo);
                viewCars.Add(viewCar);
            }

            return View(viewCars);

        }
        public ActionResult GetListOfModels()
        {
            List<Car> allCars = database.Car.ToList();
            List<string> allModels = new List<string>();

            foreach (var car in allCars)
            {
                allModels.Add(car.Model);
            }

            return View(allModels);
        }
        [HttpGet]
        public ActionResult GetCarByModel(string model)
        {
        List<Car> allCars = database.Car.ToList();

        var car = allCars.Where(a => a.Model.ToLower() == model.ToLower()).FirstOrDefault();
        CarVM viewCar = new CarVM(car.Model, car.Manufacturer, Convert.ToInt32(car.Price), car.Photo);

        return View(viewCar);
        }
        [HttpGet]
        public ActionResult ContactForm()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ContactForm(ContactForm userData)
        {
            string fullName = userData.Name + " " + userData.Surname;
            ViewBag.UserName = fullName;

            return View("ContactFormGreetings");
        }
    }
}