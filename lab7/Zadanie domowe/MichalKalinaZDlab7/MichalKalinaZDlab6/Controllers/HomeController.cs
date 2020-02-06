using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MichalKalinaZDlab6;
using MichalKalinaZDlab6.Models;
using MichalKalinaZDlab6.ViewModels;
using System.Data.SqlClient;
using System.Data;
using System.Data.Entity;

namespace Michał_Kalina_Lab6_Zadanie_domowe.Controllers
{
    public class HomeController : Controller
    {
        //POLACZENIE Z BAZA DANYCH
        ZD6Entities database = new ZD6Entities();
        //Dodanie wszytkich okien
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Michał Kalina";

            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Michał Kalina";

            return View();
        }
        //pokazanie uzytkownikow wszystkich
        public ActionResult ViewUsers()
        {
            List<Users> allUsers = database.Users.ToList();

            List<UserVM> viewUsers = new List<UserVM>();
            foreach (var user in allUsers)
            {
                UserVM viewUser = new UserVM(user.UserName, user.Surname, Convert.ToInt32(user.Number));
  
                viewUsers.Add(viewUser);
            }

            return View(viewUsers);

        }
        //rejestracja
        [HttpGet]
        public ActionResult Register()
        {
             return View();
        }
        [HttpPost]
        public ActionResult Register(Register userData)
        {
            //zmienna potrzebna do podziekowan
            string fullName = userData.Name + " " + userData.Surname;
            ViewBag.UserName = fullName;

            //dodawanie uzytkownika
            Users model = new Users();

            //dodawanie wszystkiego do model
            model.UserName = userData.Name.Trim();
            model.Surname = userData.Surname.Trim();
            model.Number = userData.Number;

            //dodawanie model do bazy tak jakby
            database.Users.Add(model);

            //zapisywanie zmian w bazie
            database.SaveChanges();

            //otwieranie podziekowan
            return View("Greetings");
        }


        //rezygnacja
        [HttpGet]
        public ActionResult Quit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Quit(Quit userDataToQuit)
        {
            //zmienna potrzebna do podziekowan
            string fullName = userDataToQuit.Name + " " + userDataToQuit.Surname;
            Users model = new Users();
            //polaczenie z baza
            SqlConnection connection;
            connection = new SqlConnection(@"Data Source=KALINA\MICHALSQL; database=ZD6;Trusted_connection=yes");

            //usuwanie model z bazy tak jakby
            SqlCommand command = new SqlCommand($@"DELETE FROM Users WHERE UserName=@name AND Surname=@surname", connection);
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = userDataToQuit.Name.Trim();
            command.Parameters.Add("@surname", SqlDbType.NVarChar).Value = userDataToQuit.Surname.Trim();
            connection.Open();
            //zmien
            command.ExecuteNonQuery();

            connection.Close(); //zamyka polaczenie
            database.SaveChanges();

            //otwieranie podziekowan
            return View("Greetings");
        }


        //zmiana numeru
        [HttpGet]
        public ActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Update(Update userData)
        {
            //zmienna potrzebna do podziekowan
            string fullName = userData.Name + " " + userData.Surname;
            ViewBag.UserName = fullName;

            //dodawanie uzytkownika
            Users model = new Users();
            using (ZD6Entities ZD6= new ZD6Entities())
            {
                model = ZD6.Users.Where(x => x.UserName == userData.Name.Trim() && x.Surname == userData.Surname.Trim()).FirstOrDefault();
                
                //dodawanie numeru do model
                model.Number = userData.Number;

                //zapisywanie itd.
                ZD6.Entry(model).State = EntityState.Modified;
                ZD6.SaveChanges();
            }
            

            //zapisywanie zmian w bazie 
            database.SaveChanges();

            //otwieranie podziekowan
            return View("Greetings");
        }
    }
}