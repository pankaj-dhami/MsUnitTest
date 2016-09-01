using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private IUnitofWork _repo;
        public HomeController(IUnitofWork _repo)
        {
            this._repo = _repo;
        }
        public ActionResult Index()
        {
            var modal = _repo.Repository.GetAllModal(1);

            return View(modal);
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
    }
}