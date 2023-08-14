using Abp.Modules;
using Abp.Reflection.Extensions;

namespace AnhDuyCompany.ManagerCompany
{
    public class ManagerCompanyClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ManagerCompanyClientModule).GetAssembly());
        }
    }
}
