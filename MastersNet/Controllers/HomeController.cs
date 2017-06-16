using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dal.Models;
using DalService.Abstract;
using DalService.Repositories;

namespace MastersNet.Controllers
{
    public class HomeController : Controller
    {
        private IRepository<Speciality> _repository;

        public HomeController()
        {
            _repository = new Repository<Speciality>();
        }
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
                var data = _repository.GetPage();
                return View(data);
        }

        protected override void Dispose(bool disposing)
        {
            _repository.Dispose();
            base.Dispose(disposing);
        }

        public ActionResult ChangeCulture(string lang)
        {
            var returnUrl = Request.UrlReferrer.AbsolutePath;
            // Список культур
            var cultures = new List<string> { "ru", "en" };
            if (!cultures.Contains(lang))
            {
                lang = "en";
            }
            // Сохраняем выбранную культуру в куки
            var cookie = Request.Cookies["lang"];
            if (cookie != null)
                cookie.Value = lang;   // если куки уже установлено, то обновляем значение
            else
            {
                cookie = new HttpCookie("lang")
                {
                    HttpOnly = false,
                    Value = lang,
                    Expires = DateTime.Now.AddYears(1)
                };
            }
            Response.Cookies.Add(cookie);
            return Redirect(returnUrl);
        }
    }
}