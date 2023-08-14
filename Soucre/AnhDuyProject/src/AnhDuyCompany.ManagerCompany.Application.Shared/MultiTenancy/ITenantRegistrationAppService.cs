using System.Threading.Tasks;
using Abp.Application.Services;
using AnhDuyCompany.ManagerCompany.Editions.Dto;
using AnhDuyCompany.ManagerCompany.MultiTenancy.Dto;

namespace AnhDuyCompany.ManagerCompany.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}