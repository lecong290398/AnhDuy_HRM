using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace AnhDuyCompany.ManagerCompany.Startup
{
    [DependsOn(typeof(ManagerCompanyCoreModule))]
    public class ManagerCompanyGraphQLModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ManagerCompanyGraphQLModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            base.PreInitialize();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }
    }
}