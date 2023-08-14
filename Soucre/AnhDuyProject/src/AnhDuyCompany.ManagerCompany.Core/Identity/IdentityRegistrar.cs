using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using AnhDuyCompany.ManagerCompany.Authentication.TwoFactor.Google;
using AnhDuyCompany.ManagerCompany.Authorization;
using AnhDuyCompany.ManagerCompany.Authorization.Roles;
using AnhDuyCompany.ManagerCompany.Authorization.Users;
using AnhDuyCompany.ManagerCompany.Editions;
using AnhDuyCompany.ManagerCompany.MultiTenancy;

namespace AnhDuyCompany.ManagerCompany.Identity
{
    public static class IdentityRegistrar
    {
        public static IdentityBuilder Register(IServiceCollection services)
        {
            services.AddLogging();

            return services.AddAbpIdentity<Tenant, User, Role>(options =>
                {
                    options.Tokens.ProviderMap[GoogleAuthenticatorProvider.Name] = new TokenProviderDescriptor(typeof(GoogleAuthenticatorProvider));
                })
                .AddAbpTenantManager<TenantManager>()
                .AddAbpUserManager<UserManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpEditionManager<EditionManager>()
                .AddAbpUserStore<UserStore>()
                .AddAbpRoleStore<RoleStore>()
                .AddAbpSignInManager<SignInManager>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddAbpSecurityStampValidator<SecurityStampValidator>()
                .AddPermissionChecker<PermissionChecker>()
                .AddDefaultTokenProviders();
        }
    }
}
