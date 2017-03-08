using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyBookKeeping.Models;
using MyBookKeeping.Models.ViewModels;

namespace MyBookKeeping.Controllers
{
    public class BookingController : Controller
    {
        static ProcessViewModel DataModel = new ProcessViewModel();
        List<BookingsModels> ListDetail = DataModel.InitData();

        // GET: Booking
        public ActionResult Index()
        {
            return View(ListDetail);
        }

        // GET: Booking/Create
        public ActionResult Create()
        {
            return View(ListDetail);
        }

        // POST: Booking/Create
        [HttpPost]
        public ActionResult Create(BookingsModels collection)
        {
            return View(ListDetail);
        }
    }
}