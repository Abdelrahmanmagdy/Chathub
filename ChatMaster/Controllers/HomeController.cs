using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChatMaster.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Chat Master";

            return View();
        }

        public JsonResult GetChatMasters()
        {
            return Json("");
        }
        public JsonResult GetChatDetails(int ID)
        {
            return Json("");

        }

        [HttpPost]
        public JsonResult InsertChatMessage(string Message, int To)
        {
            return Json("");
        }

    }
}
