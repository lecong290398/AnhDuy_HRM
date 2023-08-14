using Microsoft.AspNetCore.Antiforgery;

namespace AnhDuyCompany.ManagerCompany.Web.Controllers
{
    public class AntiForgeryController : ManagerCompanyControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
