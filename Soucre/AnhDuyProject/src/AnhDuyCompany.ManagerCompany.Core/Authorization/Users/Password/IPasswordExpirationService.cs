using Abp.Domain.Services;

namespace AnhDuyCompany.ManagerCompany.Authorization.Users.Password
{
    public interface IPasswordExpirationService : IDomainService
    {
        void ForcePasswordExpiredUsersToChangeTheirPassword();
    }
}
