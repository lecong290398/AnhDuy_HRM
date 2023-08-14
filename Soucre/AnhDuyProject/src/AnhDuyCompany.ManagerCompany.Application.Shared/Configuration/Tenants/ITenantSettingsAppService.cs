using System.Threading.Tasks;
using Abp.Application.Services;
using AnhDuyCompany.ManagerCompany.Configuration.Tenants.Dto;

namespace AnhDuyCompany.ManagerCompany.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearDarkLogo();
        
        Task ClearLightLogo();

        Task ClearCustomCss();
    }
}
