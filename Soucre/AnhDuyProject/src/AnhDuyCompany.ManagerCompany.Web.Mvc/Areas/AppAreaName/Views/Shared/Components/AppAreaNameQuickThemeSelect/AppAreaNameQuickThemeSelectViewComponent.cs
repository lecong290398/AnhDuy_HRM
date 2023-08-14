using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AnhDuyCompany.ManagerCompany.Web.Areas.AppAreaName.Models.Layout;
using AnhDuyCompany.ManagerCompany.Web.Views;

namespace AnhDuyCompany.ManagerCompany.Web.Areas.AppAreaName.Views.Shared.Components.
    AppAreaNameQuickThemeSelect
{
    public class AppAreaNameQuickThemeSelectViewComponent : ManagerCompanyViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(string cssClass, string iconClass = "flaticon-interface-7 fs-2")
        {
            return Task.FromResult<IViewComponentResult>(View(new QuickThemeSelectionViewModel
            {
                CssClass = cssClass,
                IconClass = iconClass
            }));
        }
    }
}
