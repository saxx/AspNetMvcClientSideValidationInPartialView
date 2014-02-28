using System.Web.Mvc;
using AspNetMvcClientSideValidationInPartialView.Models;

namespace AspNetMvcClientSideValidationInPartialView.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(IndexViewModel model)
        {
            return View();
        }
    }
}