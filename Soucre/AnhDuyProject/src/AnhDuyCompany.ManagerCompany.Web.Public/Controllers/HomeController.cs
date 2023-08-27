using AnhDuyCompany.ManagerCompany.Web.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace AnhDuyCompany.ManagerCompany.Web.Public.Controllers
{
    public class HomeController : ManagerCompanyControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult HomeIndex()
        {
            return View();
        }
    }
}