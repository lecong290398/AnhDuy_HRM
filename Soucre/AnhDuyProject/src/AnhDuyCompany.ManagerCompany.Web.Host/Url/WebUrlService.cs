using Abp.Dependency;
using AnhDuyCompany.ManagerCompany.Configuration;
using AnhDuyCompany.ManagerCompany.Url;

namespace AnhDuyCompany.ManagerCompany.Web.Url
{
    public class WebUrlService : WebUrlServiceBase, IWebUrlService, ITransientDependency
    {
        public WebUrlService(
            IAppConfigurationAccessor configurationAccessor) :
            base(configurationAccessor)
        {
        }

        public override string WebSiteRootAddressFormatKey => "App:ClientRootAddress";

        public override string ServerRootAddressFormatKey => "App:ServerRootAddress";
    }
}