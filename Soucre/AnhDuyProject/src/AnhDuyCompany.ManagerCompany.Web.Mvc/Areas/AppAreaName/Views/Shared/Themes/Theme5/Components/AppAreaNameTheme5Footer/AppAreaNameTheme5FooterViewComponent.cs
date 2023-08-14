using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AnhDuyCompany.ManagerCompany.Web.Areas.AppAreaName.Models.Layout;
using AnhDuyCompany.ManagerCompany.Web.Session;
using AnhDuyCompany.ManagerCompany.Web.Views;

namespace AnhDuyCompany.ManagerCompany.Web.Areas.AppAreaName.Views.Shared.Themes.Theme5.Components.AppAreaNameTheme5Footer
{
    public class AppAreaNameTheme5FooterViewComponent : ManagerCompanyViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppAreaNameTheme5FooterViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var footerModel = new FooterViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(footerModel);
        }
    }
}
