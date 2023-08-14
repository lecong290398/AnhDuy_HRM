using AnhDuyCompany.ManagerCompany.Sessions.Dto;

namespace AnhDuyCompany.ManagerCompany.Web.Areas.AppAreaName.Models.Layout
{
    public class SubscriptionBarViewModel
    {
        public int SubscriptionExpireNotifyDayCount { get; set; }

        public GetCurrentLoginInformationsOutput LoginInformations { get; set; }

        public string CssClass { get; set; }
    }
}
