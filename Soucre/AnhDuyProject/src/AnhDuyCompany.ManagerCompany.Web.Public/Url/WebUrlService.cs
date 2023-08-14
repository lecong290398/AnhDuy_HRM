using Abp.Dependency;
using AnhDuyCompany.ManagerCompany.Configuration;
using AnhDuyCompany.ManagerCompany.Url;
using AnhDuyCompany.ManagerCompany.Web.Url;

namespace AnhDuyCompany.ManagerCompany.Web.Public.Url
{
    public class WebUrlService : WebUrlServiceBase, IWebUrlService, ITransientDependency
    {
        public WebUrlService(
            IAppConfigurationAccessor appConfigurationAccessor) :
            base(appConfigurationAccessor)
        {
        }

        public override string WebSiteRootAddressFormatKey => "App:WebSiteRootAddress";

        public override string ServerRootAddressFormatKey => "App:AdminWebSiteRootAddress";
    }
}