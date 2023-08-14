using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AnhDuyCompany.ManagerCompany.Authorization;

namespace AnhDuyCompany.ManagerCompany
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(ManagerCompanyApplicationSharedModule),
        typeof(ManagerCompanyCoreModule)
        )]
    public class ManagerCompanyApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ManagerCompanyApplicationModule).GetAssembly());
        }
    }
}