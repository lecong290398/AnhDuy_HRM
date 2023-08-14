using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace AnhDuyCompany.ManagerCompany.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
