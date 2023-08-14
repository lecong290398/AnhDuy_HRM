using Abp.Modules;
using Abp.Reflection.Extensions;

namespace AnhDuyCompany.ManagerCompany
{
    [DependsOn(typeof(ManagerCompanyCoreSharedModule))]
    public class ManagerCompanyApplicationSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ManagerCompanyApplicationSharedModule).GetAssembly());
        }
    }
}