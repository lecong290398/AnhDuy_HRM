using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace AnhDuyCompany.ManagerCompany.Web.Public.Views
{
    public abstract class ManagerCompanyRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected ManagerCompanyRazorPage()
        {
            LocalizationSourceName = ManagerCompanyConsts.LocalizationSourceName;
        }
    }
}
