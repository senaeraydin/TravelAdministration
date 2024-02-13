using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TourismTravelAdministration.Models;
using TourismTravelAdministration.Data;
namespace TourismTravelAdministration.Controllers
{
    public class HomeController : Controller
    {
        public TourismTravelAdministrationContext _dbContext;

        public HomeController()
        {
            _dbContext = new TourismTravelAdministrationContext();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {

            return View();
        }
        [HttpGet]
        public ActionResult Contact()
        {

            return View();
        }

        public ActionResult TravelPhotos()
        {
            return View();
        }
        public ActionResult Amalfi()
        {
            return View();
        }
        public ActionResult Florence()
        {
            return View();
        }
        public ActionResult Venice()
        {
            return View();
        }
        public ActionResult Milan()
        {
            return View();
        }
        public ActionResult Rome()
        {
            return View();
        }
        public ActionResult Verona()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Contact(Contact conta)
        {
            if (ModelState.IsValid)
            {
                ViewBag.name = conta.Name;
                ViewBag.phoneNumber = conta.PhoneNumber;
                ViewBag.email = conta.Email;
                ViewBag.message = conta.Message;
                return View("ResultForm", conta);
            }
            else
            {
                return View();
            }
        }

        public ActionResult Tour_List()
        {
            List<Tour> tourList = _dbContext.Tours.ToList();
            return View(tourList);
        }

        public ActionResult Tour_Info(int id)
        {

            var tour = _dbContext.Tours.Find(id);
            return View(tour);

           
        }

        [Authorize(Roles = "User")]
        [HttpGet]
        public ActionResult PaymentForm()
        {
            return View();
            
        }

        [HttpPost]
        public ActionResult PaymentForm(Payment py)
        {
            if (ModelState.IsValid)
            {
                ViewBag.cardOwnerName = py.CardOwnerName;
                ViewBag.cardNumber = py.CardNumber;
                ViewBag.expDate = py.ExpDate;
                ViewBag.securityCode = py.SecurityCode;
                return View("PaymentResult", py);
            }
            else
            {
                return View();
            }
        }

        public ActionResult Login()
        {
            return RedirectToAction("Login", "Account");
        }
    }
}