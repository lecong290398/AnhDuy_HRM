using Abp.Dependency;
using Abp.Reflection.Extensions;
using Microsoft.Extensions.Configuration;
using AnhDuyCompany.ManagerCompany.Configuration;

namespace AnhDuyCompany.ManagerCompany.Test.Base.Configuration
{
    public class TestAppConfigurationAccessor : IAppConfigurationAccessor, ISingletonDependency
    {
        public IConfigurationRoot Configuration { get; }

        public TestAppConfigurationAccessor()
        {
            Configuration = AppConfigurations.Get(
                typeof(ManagerCompanyTestBaseModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }
    }
}
