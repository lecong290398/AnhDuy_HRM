using System.Collections.Generic;
using AnhDuyCompany.ManagerCompany.Authorization.Permissions.Dto;

namespace AnhDuyCompany.ManagerCompany.Web.Areas.AppAreaName.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }

        List<string> GrantedPermissionNames { get; set; }
    }
}