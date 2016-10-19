using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WORK.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult cyj ()
        {
            

            return View();
        }
        /// <summary>
        /// 新闻列表
        /// </summary>
        /// <returns></returns>
        public ActionResult list()
        {
            string[] data = new string[] { "台风“莎莉嘉”逼近广西 景区关闭学校停课" , "台风“莎莉嘉”裹挟强降雨影响海南广东广西", "受台风“彩虹”影响 广西5日风雨最强" };
            ViewBag.data = data;

            return View();
        }
    }
}