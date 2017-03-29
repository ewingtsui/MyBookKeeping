using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MyBookKeeping.Models.Service;
using MyBookKeeping.Models.ViewModels;

namespace MyBookKeeping.Controllers
{
    public class BookingController : Controller
    {
        AccountBookService AccountBookService = new AccountBookService();

        // GET: Booking
        public ActionResult Index()
        {
            var source = AccountBookService.AccountBookList();
            return View(source);
        }

        // GET: Booking/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Booking/Create
        [HttpPost]
        public ActionResult Create(BookingsViewModels model)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid == true)
                {
                    AccountBookService.AddData(model);
                }               

                return RedirectToAction("Index");
            }
            catch
            {
                model.Message =  
                    $"有錯誤: ";
                //return View();
                return RedirectToAction("About", "Home");
            }
        }
    }
}