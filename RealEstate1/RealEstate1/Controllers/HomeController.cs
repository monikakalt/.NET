using System.Web.Mvc;
using RealEstate1.App_Start;

namespace RealEstate1.Controllers
{
    public class HomeController : Controller
    {
       public RealEstateContext Context=new RealEstateContext();

        public ActionResult Index()
        {
            Context.Database.GetStats();
            return Json(Context.Database.Server.BuildInfo, JsonRequestBehavior.AllowGet);
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