using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MyBookKeeping.Models.Service;
using MyBookKeeping.Models.ViewModels;
using MyBookKeeping.Models;

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
        [ValidateAntiForgeryToken]
        public ActionResult Create(BookingsViewModels model)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    AccountBook  acct = new AccountBook()
                    {
                        Id = Guid.NewGuid(),
                        Categoryyy = Convert.ToInt32(model.BookType),
                        Amounttt = model.BookAmount,
                        Dateee = model.BookDate,
                        Remarkkk = model.BookMemo
                    };

                    AccountBookService.AddData(acct);
                    AccountBookService.Save();
                    return RedirectToAction("Index");
                }

                return View(model);
            }
            catch
            {
                return View();
            }
        }
    }
}