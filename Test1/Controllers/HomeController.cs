using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test1.Class_Db;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Dashboard()
        {

            ViewBag.KeyWord = "لوله بازکنی،لوله بازکنی،لوله،تخلیه چاه،تخلیه چاه،" +
                "،ترکیدگی لوله،لوله بازکنی حرفه ای،لوله باز کنی حرفه ای،لوله باز کنی";
           

            ViewBag.Title = "لوله بازکنی شبانه روزی ماهر کار ارزان و فوری  - 09392920180 ";
            ViewBag.City = "ایران";

            return View();
        }
        public ActionResult Tehran()
        {

            ViewBag.KeyWord = "لوله بازکنی،لوله بازکنی تهران،لوله،تخلیه چاه،تخلیه چاه تهران،" +
              "تهران،ترکیدگی لوله،لوله بازکنی حرفه ای،لوله باز کنی حرفه ای،لوله باز کنی شرق تهران,لوله باز کنی غرب تهران" +
              "لوله باز کنی تهران,تهران،ترکیدگی لوله،لوله بازکنی حرفه ای،لوله باز کنی حرفه ای،لوله باز کنی تهران,لوله باز کنی شرق تهران" +
              "غرب تهران،ترکیدگی لوله،لوله بازکنی حرفه ای،لوله باز کنی حرفه ای،لوله باز کنی جنوب تهران";

            ViewBag.Title = "لوله بازکنی شبانه روزی تهران ارزان و فوری  - 09392920180 ";
            ViewBag.City = " تهران";

          
            


            //لوله بازکنی شبانه روزی تهران ارزان و فوری 📞 - 09392920180 📞
            return View();
        }

        public ActionResult Zanjan()
        {

            ViewBag.KeyWord = "لوله بازکنی،لوله بازکنی زنجان،لوله،تخلیه چاه،تخلیه چاه زنجان،" +
               "زنجان،ترکیدگی لوله،لوله بازکنی حرفه ای،لوله باز کنی حرفه ای،لوله باز کنی ابهر";

            ViewBag.Title = "لوله بازکنی شبانه روزی زنجان ارزان و فوری  - 09392920180 ";

            ViewBag.City = " زنجان";

            return View();
        }

        public ActionResult Alborz()
        {


            ViewBag.KeyWord = "لوله بازکنی البرز،لوله بازکنی کرج،لوله،تخلیه چاه،تخلیه چاه کرج،" +
               "کرج،ترکیدگی لوله،لوله بازکنی حرفه ای،لوله باز کنی حرفه ای،لوله باز کنی کرج";


            ViewBag.Title = "لوله بازکنی شبانه روزی البرز ارزان و فوری  - 09392920180 ";
            ViewBag.City = " البرز";

            return View();
        }

        public ActionResult Esfahan()
        {

            ViewBag.KeyWord = "لوله بازکنی،لوله بازکنی اصفهان،لوله،تخلیه چاه،تخلیه چاه اصفهان،" +
               "اصفهان،ترکیدگی لوله،لوله بازکنی حرفه ای،لوله باز کنی حرفه ای،لوله باز کنی اصفهان";

            ViewBag.Title = "لوله بازکنی شبانه روزی اصفهان ارزان و فوری  - 09392920180 ";
            ViewBag.City = " اصفهان";

            return View();
        }


        public ActionResult test()
        {
            return View();
        }

        public ActionResult Test2()
        {
            return View();
        }
    }
}