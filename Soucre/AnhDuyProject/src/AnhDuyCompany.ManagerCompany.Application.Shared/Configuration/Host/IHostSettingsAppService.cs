using System.Threading.Tasks;
using Abp.Application.Services;
using AnhDuyCompany.ManagerCompany.Configuration.Host.Dto;

namespace AnhDuyCompany.ManagerCompany.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
