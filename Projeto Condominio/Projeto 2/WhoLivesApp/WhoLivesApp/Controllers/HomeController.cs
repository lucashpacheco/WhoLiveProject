using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WhoLivesApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "O que é WhoLive's ? ";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Em caso de nessecidade de suporte entre em contato";

            return View();
        }
        public ActionResult Reports()
        {
            ViewBag.Message = "Escolha qual tipo de relatorio deseja exibir";

            return View();
        }

        public ActionResult Report1() 
        {
            return View();
        }
    }
}