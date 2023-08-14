using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AnhDuyCompany.ManagerCompany.Authorization.Permissions.Dto;

namespace AnhDuyCompany.ManagerCompany.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
