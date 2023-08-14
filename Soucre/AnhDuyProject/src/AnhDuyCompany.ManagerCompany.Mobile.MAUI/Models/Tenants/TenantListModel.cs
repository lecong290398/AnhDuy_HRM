using Abp.AutoMapper;
using AnhDuyCompany.ManagerCompany.MultiTenancy.Dto;

namespace AnhDuyCompany.ManagerCompany.Mobile.MAUI.Models.Tenants
{
    [AutoMapFrom(typeof(TenantListDto))]
    [AutoMapTo(typeof(TenantEditDto), typeof(CreateTenantInput))]
    public class TenantListModel : TenantListDto
    {
 
    }
}
