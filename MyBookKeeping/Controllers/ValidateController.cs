using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBookKeeping.Controllers
{
    public class ValidateController : Controller
    {
        public ActionResult CheckToday(DateTime bookDate)
        {
            bool isValidate = (bookDate < DateTime.Now);

            return Json(isValidate, JsonRequestBehavior.AllowGet);
        }
    }
}