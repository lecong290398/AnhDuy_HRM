using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using AnhDuyCompany.ManagerCompany.WebHooks.Dto;

namespace AnhDuyCompany.ManagerCompany.WebHooks
{
    public interface IWebhookAttemptAppService
    {
        Task<PagedResultDto<GetAllSendAttemptsOutput>> GetAllSendAttempts(GetAllSendAttemptsInput input);

        Task<ListResultDto<GetAllSendAttemptsOfWebhookEventOutput>> GetAllSendAttemptsOfWebhookEvent(GetAllSendAttemptsOfWebhookEventInput input);
    }
}
