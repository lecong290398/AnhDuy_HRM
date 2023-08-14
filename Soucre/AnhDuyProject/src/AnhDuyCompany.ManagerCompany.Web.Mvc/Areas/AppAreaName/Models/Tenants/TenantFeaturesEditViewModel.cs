using Abp.AutoMapper;
using AnhDuyCompany.ManagerCompany.MultiTenancy;
using AnhDuyCompany.ManagerCompany.MultiTenancy.Dto;
using AnhDuyCompany.ManagerCompany.Web.Areas.AppAreaName.Models.Common;

namespace AnhDuyCompany.ManagerCompany.Web.Areas.AppAreaName.Models.Tenants
{
    [AutoMapFrom(typeof (GetTenantFeaturesEditOutput))]
    public class TenantFeaturesEditViewModel : GetTenantFeaturesEditOutput, IFeatureEditViewModel
    {
        public Tenant Tenant { get; set; }
    }
}