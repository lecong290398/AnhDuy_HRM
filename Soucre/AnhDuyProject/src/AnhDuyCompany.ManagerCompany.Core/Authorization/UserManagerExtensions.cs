using System.Threading.Tasks;
using Abp.Authorization.Users;
using AnhDuyCompany.ManagerCompany.Authorization.Users;

namespace AnhDuyCompany.ManagerCompany.Authorization
{
    public static class UserManagerExtensions
    {
        public static async Task<User> GetAdminAsync(this UserManager userManager)
        {
            return await userManager.FindByNameAsync(AbpUserBase.AdminUserName);
        }
        
        public static User GetAdmin(this UserManager userManager)
        {
            return userManager.FindByNameOrEmail(AbpUserBase.AdminUserName);
        }
    }
}
