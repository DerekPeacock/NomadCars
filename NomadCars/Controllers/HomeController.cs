using NomadCars.DAL;
using System.Data.Entity;
using System.Web.Mvc;

namespace NomadCars.Controllers
{
    public class HomeController : Controller
    {
        private NomadDbContext db = new NomadDbContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your About Us page.";

            return View();
        }

        public ActionResult UsedCars()
        {
            ViewBag.Message = "Your Used Cars page.";
            var cars = db.Cars.Include(c => c.CarSpec).Include(i => i.ImagesList);

            return View(cars);
        }

        public ActionResult CarDetails()
        {
            ViewBag.Message = "Your Car Details page.";
            var cars = db.Cars.Include(c => c.CarSpec).Include(i => i.ImagesList);

            return View(cars);
        }


        public ActionResult Finance()
        {
            ViewBag.Message = "Your Finance page.";

            return View();
        }
    }
}