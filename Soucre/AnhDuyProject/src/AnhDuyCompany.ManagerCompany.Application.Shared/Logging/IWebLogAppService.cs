using Abp.Application.Services;
using AnhDuyCompany.ManagerCompany.Dto;
using AnhDuyCompany.ManagerCompany.Logging.Dto;

namespace AnhDuyCompany.ManagerCompany.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
