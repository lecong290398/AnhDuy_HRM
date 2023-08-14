using System.Collections.Generic;
using AnhDuyCompany.ManagerCompany.Authorization.Delegation;
using AnhDuyCompany.ManagerCompany.Authorization.Users.Delegation.Dto;

namespace AnhDuyCompany.ManagerCompany.Web.Areas.AppAreaName.Models.Layout
{
    public class ActiveUserDelegationsComboboxViewModel
    {
        public IUserDelegationConfiguration UserDelegationConfiguration { get; set; }

        public List<UserDelegationDto> UserDelegations { get; set; }

        public string CssClass { get; set; }
    }
}
