using Abp.AutoMapper;
using AnhDuyCompany.ManagerCompany.Authorization.Users;
using AnhDuyCompany.ManagerCompany.Authorization.Users.Dto;
using AnhDuyCompany.ManagerCompany.Web.Areas.AppAreaName.Models.Common;

namespace AnhDuyCompany.ManagerCompany.Web.Areas.AppAreaName.Models.Users
{
    [AutoMapFrom(typeof(GetUserPermissionsForEditOutput))]
    public class UserPermissionsEditViewModel : GetUserPermissionsForEditOutput, IPermissionsEditViewModel
    {
        public User User { get; set; }
    }
}