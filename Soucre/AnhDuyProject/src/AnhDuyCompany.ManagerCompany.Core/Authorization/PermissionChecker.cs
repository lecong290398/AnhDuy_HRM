using Abp.Authorization;
using AnhDuyCompany.ManagerCompany.Authorization.Roles;
using AnhDuyCompany.ManagerCompany.Authorization.Users;

namespace AnhDuyCompany.ManagerCompany.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
