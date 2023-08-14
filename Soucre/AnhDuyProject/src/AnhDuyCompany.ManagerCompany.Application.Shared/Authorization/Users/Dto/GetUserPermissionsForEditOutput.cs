using System.Collections.Generic;
using AnhDuyCompany.ManagerCompany.Authorization.Permissions.Dto;

namespace AnhDuyCompany.ManagerCompany.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}