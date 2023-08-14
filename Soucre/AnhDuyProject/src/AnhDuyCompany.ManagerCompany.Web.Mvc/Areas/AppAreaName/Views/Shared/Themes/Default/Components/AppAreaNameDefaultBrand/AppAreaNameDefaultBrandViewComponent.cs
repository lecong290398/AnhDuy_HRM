using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AnhDuyCompany.ManagerCompany.Web.Areas.AppAreaName.Models.Layout;
using AnhDuyCompany.ManagerCompany.Web.Session;
using AnhDuyCompany.ManagerCompany.Web.Views;

namespace AnhDuyCompany.ManagerCompany.Web.Areas.AppAreaName.Views.Shared.Themes.Default.Components.AppAreaNameDefaultBrand
{
    public class AppAreaNameDefaultBrandViewComponent : ManagerCompanyViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppAreaNameDefaultBrandViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var headerModel = new HeaderViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(headerModel);
        }
    }
}
