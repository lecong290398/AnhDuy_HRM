using Microsoft.AspNetCore.Mvc;
using AnhDuyCompany.ManagerCompany.Web.Controllers;

namespace AnhDuyCompany.ManagerCompany.Web.Public.Controllers
{
    public class HomeController : ManagerCompanyControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}