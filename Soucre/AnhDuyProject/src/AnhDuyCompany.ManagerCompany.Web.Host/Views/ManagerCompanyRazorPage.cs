using Abp.AspNetCore.Mvc.Views;

namespace AnhDuyCompany.ManagerCompany.Web.Views
{
    public abstract class ManagerCompanyRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected ManagerCompanyRazorPage()
        {
            LocalizationSourceName = ManagerCompanyConsts.LocalizationSourceName;
        }
    }
}
