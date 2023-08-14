using Abp.AspNetCore.Mvc.ViewComponents;

namespace AnhDuyCompany.ManagerCompany.Web.Views
{
    public abstract class ManagerCompanyViewComponent : AbpViewComponent
    {
        protected ManagerCompanyViewComponent()
        {
            LocalizationSourceName = ManagerCompanyConsts.LocalizationSourceName;
        }
    }
}