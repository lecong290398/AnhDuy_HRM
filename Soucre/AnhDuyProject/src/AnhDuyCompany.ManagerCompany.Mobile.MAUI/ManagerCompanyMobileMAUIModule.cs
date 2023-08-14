using Abp.AutoMapper;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AnhDuyCompany.ManagerCompany.ApiClient;
using AnhDuyCompany.ManagerCompany.Mobile.MAUI.Core.ApiClient;

namespace AnhDuyCompany.ManagerCompany
{
    [DependsOn(typeof(ManagerCompanyClientModule), typeof(AbpAutoMapperModule))]

    public class ManagerCompanyMobileMAUIModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.IsEnabled = false;
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;

            Configuration.ReplaceService<IApplicationContext, MAUIApplicationContext>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ManagerCompanyMobileMAUIModule).GetAssembly());
        }
    }
}