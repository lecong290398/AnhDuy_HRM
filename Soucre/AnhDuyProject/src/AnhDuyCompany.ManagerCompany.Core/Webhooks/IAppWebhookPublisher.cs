using System.Threading.Tasks;
using AnhDuyCompany.ManagerCompany.Authorization.Users;

namespace AnhDuyCompany.ManagerCompany.WebHooks
{
    public interface IAppWebhookPublisher
    {
        Task PublishTestWebhook();
    }
}
