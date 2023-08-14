using System.Threading.Tasks;
using Abp.Webhooks;

namespace AnhDuyCompany.ManagerCompany.WebHooks
{
    public interface IWebhookEventAppService
    {
        Task<WebhookEvent> Get(string id);
    }
}
