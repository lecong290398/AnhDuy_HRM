using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AnhDuyCompany.ManagerCompany.Web.Areas.AppAreaName.Models.Layout;
using AnhDuyCompany.ManagerCompany.Web.Views;

namespace AnhDuyCompany.ManagerCompany.Web.Areas.AppAreaName.Views.Shared.Components.AppAreaNameToggleDarkMode
{
    public class AppAreaNameToggleDarkModeViewComponent : ManagerCompanyViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(string cssClass, bool isDarkModeActive)
        {
            return Task.FromResult<IViewComponentResult>(View(new ToggleDarkModeViewModel(cssClass, isDarkModeActive)));
        }
    }
}