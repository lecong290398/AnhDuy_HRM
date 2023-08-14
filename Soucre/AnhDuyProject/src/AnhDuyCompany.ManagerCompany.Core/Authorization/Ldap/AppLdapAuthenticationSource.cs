using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using AnhDuyCompany.ManagerCompany.Authorization.Users;
using AnhDuyCompany.ManagerCompany.MultiTenancy;

namespace AnhDuyCompany.ManagerCompany.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}