using Abp.AutoMapper;
using AnhDuyCompany.ManagerCompany.ApiClient;

namespace AnhDuyCompany.ManagerCompany.Models.Common
{
    [AutoMapFrom(typeof(TenantInformation)),
     AutoMapTo(typeof(TenantInformation))]
    public class TenantInformationPersistanceModel
    {
        public string TenancyName { get; set; }

        public int TenantId { get; set; }
    }
}