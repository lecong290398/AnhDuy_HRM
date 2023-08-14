using System.Threading.Tasks;
using Abp.Application.Services;
using AnhDuyCompany.ManagerCompany.Install.Dto;

namespace AnhDuyCompany.ManagerCompany.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}