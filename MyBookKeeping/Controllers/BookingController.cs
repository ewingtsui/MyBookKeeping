using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MyBookKeeping.Models.Service;

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
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}