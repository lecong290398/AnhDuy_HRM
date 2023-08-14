using Microsoft.Extensions.Configuration;

namespace AnhDuyCompany.ManagerCompany.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
