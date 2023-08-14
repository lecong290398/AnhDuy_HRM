using Abp.Auditing;
using AnhDuyCompany.ManagerCompany.Configuration.Dto;

namespace AnhDuyCompany.ManagerCompany.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}