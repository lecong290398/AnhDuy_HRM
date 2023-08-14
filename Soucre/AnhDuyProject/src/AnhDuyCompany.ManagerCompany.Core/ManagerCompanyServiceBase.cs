using Abp;

namespace AnhDuyCompany.ManagerCompany
{
    /// <summary>
    /// This class can be used as a base class for services in this application.
    /// It has some useful objects property-injected and has some basic methods most of services may need to.
    /// It's suitable for non domain nor application service classes.
    /// For domain services inherit <see cref="ManagerCompanyDomainServiceBase"/>.
    /// For application services inherit ManagerCompanyAppServiceBase.
    /// </summary>
    public abstract class ManagerCompanyServiceBase : AbpServiceBase
    {
        protected ManagerCompanyServiceBase()
        {
            LocalizationSourceName = ManagerCompanyConsts.LocalizationSourceName;
        }
    }
}