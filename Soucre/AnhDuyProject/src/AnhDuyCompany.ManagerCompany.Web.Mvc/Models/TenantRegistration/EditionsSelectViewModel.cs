using Abp.AutoMapper;
using AnhDuyCompany.ManagerCompany.MultiTenancy.Dto;

namespace AnhDuyCompany.ManagerCompany.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(EditionsSelectOutput))]
    public class EditionsSelectViewModel : EditionsSelectOutput
    {
    }
}
