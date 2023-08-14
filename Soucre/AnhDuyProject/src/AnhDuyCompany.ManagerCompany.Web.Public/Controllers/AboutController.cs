using Microsoft.AspNetCore.Mvc;
using AnhDuyCompany.ManagerCompany.Web.Controllers;

namespace AnhDuyCompany.ManagerCompany.Web.Public.Controllers
{
    public class AboutController : ManagerCompanyControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}