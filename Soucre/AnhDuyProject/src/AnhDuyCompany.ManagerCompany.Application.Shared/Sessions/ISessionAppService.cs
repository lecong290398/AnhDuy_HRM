using System.Threading.Tasks;
using Abp.Application.Services;
using AnhDuyCompany.ManagerCompany.Sessions.Dto;

namespace AnhDuyCompany.ManagerCompany.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
