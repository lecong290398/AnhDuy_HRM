using Abp.AutoMapper;
using AnhDuyCompany.ManagerCompany.Sessions.Dto;

namespace AnhDuyCompany.ManagerCompany.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}