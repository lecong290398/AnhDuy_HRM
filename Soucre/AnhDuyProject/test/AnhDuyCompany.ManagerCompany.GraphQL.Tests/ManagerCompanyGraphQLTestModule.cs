using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using AnhDuyCompany.ManagerCompany.Configure;
using AnhDuyCompany.ManagerCompany.Startup;
using AnhDuyCompany.ManagerCompany.Test.Base;

namespace AnhDuyCompany.ManagerCompany.GraphQL.Tests
{
    [DependsOn(
        typeof(ManagerCompanyGraphQLModule),
        typeof(ManagerCompanyTestBaseModule))]
    public class ManagerCompanyGraphQLTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            IServiceCollection services = new ServiceCollection();
            
            services.AddAndConfigureGraphQL();

            WindsorRegistrationHelper.CreateServiceProvider(IocManager.IocContainer, services);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ManagerCompanyGraphQLTestModule).GetAssembly());
        }
    }
}