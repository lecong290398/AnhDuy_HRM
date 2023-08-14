using System.Threading.Tasks;
using Abp.Application.Services;

namespace AnhDuyCompany.ManagerCompany.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task DisableRecurringPayments();

        Task EnableRecurringPayments();
    }
}
