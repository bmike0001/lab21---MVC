using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab21___MVC.Models;

namespace lab21___MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Lab21
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good morning" : "Good Afternoon";
            return View();
        }
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();

        }


        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestReponse)
        {
            if (ModelState.IsValid)
            {
                //TODO: Email respoinse to the party organizer
                return View("Thanks", guestReponse);
            }
            else
            {
                //there is a validation error
                return View();
            }

            /*     [HttpGet]
                 public ViewResult Thanks(GuestResponse guestReponse)
                 {
                     return View();

                 }
                 */
        }
    }
}
