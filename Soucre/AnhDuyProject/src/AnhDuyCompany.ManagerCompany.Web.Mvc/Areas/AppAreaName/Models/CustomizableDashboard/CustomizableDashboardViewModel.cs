using AnhDuyCompany.ManagerCompany.DashboardCustomization;
using AnhDuyCompany.ManagerCompany.DashboardCustomization.Dto;

namespace AnhDuyCompany.ManagerCompany.Web.Areas.AppAreaName.Models.CustomizableDashboard
{
    public class CustomizableDashboardViewModel
    {
        public DashboardOutput DashboardOutput { get; }

        public Dashboard UserDashboard { get; }

        public CustomizableDashboardViewModel(
            DashboardOutput dashboardOutput,
            Dashboard userDashboard)
        {
            DashboardOutput = dashboardOutput;
            UserDashboard = userDashboard;
        }
    }
}