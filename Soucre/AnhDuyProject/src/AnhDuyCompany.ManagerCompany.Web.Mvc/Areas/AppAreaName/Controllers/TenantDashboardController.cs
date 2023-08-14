using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using AnhDuyCompany.ManagerCompany.Authorization;
using AnhDuyCompany.ManagerCompany.DashboardCustomization;
using System.Threading.Tasks;
using AnhDuyCompany.ManagerCompany.Web.Areas.AppAreaName.Startup;

namespace AnhDuyCompany.ManagerCompany.Web.Areas.AppAreaName.Controllers
{
    [Area("AppAreaName")]
    [AbpMvcAuthorize(AppPermissions.Pages_Tenant_Dashboard)]
    public class TenantDashboardController : CustomizableDashboardControllerBase
    {
        public TenantDashboardController(DashboardViewConfiguration dashboardViewConfiguration, 
            IDashboardCustomizationAppService dashboardCustomizationAppService) 
            : base(dashboardViewConfiguration, dashboardCustomizationAppService)
        {

        }

        public async Task<ActionResult> Index()
        {
            return await GetView(ManagerCompanyDashboardCustomizationConsts.DashboardNames.DefaultTenantDashboard);
        }
    }
}