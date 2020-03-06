using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Home
{
    public class TESTController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public JsonResult PushNotification()
        //{
        //    return Json(new
        //    {
        //        Success = true
        //    }, JsonRequestBehavior.AllowGet);
        //}

        [HttpGet]
        public JsonResult PushNotification()
        {
            return Json(new
            {
                Success = true
            }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetPushNotification()
        {
            var data = new
            {
                Name = "Anh Nhan Oiiiii!",
                Title = "Sao anh dep trai qua z Ahihi!"
            };

            return Json(new
            {
                Success = true,

                Data = data
            }, JsonRequestBehavior.AllowGet);
        }
    }
}