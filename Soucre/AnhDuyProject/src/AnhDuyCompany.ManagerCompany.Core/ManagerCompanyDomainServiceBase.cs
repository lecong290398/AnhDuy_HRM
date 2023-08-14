using Abp.Domain.Services;

namespace AnhDuyCompany.ManagerCompany
{
    public abstract class ManagerCompanyDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected ManagerCompanyDomainServiceBase()
        {
            LocalizationSourceName = ManagerCompanyConsts.LocalizationSourceName;
        }
    }
}
