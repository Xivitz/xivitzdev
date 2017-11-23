using System.Web.Mvc;

namespace xivitzdev.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Perfil";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Entre em Contato";

            return View();
        }

        public ActionResult Experiencia()
        {
            ViewBag.Message = "Experiência Profissional";
            return View();
        }
    }
}