using Abp.AutoMapper;
using AnhDuyCompany.ManagerCompany.Authorization.Users.Dto;

namespace AnhDuyCompany.ManagerCompany.Mobile.MAUI.Models.User
{
    [AutoMapFrom(typeof(UserListDto))]
    public class UserListModel : UserListDto
    {
        public string Photo { get; set; }

        public string FullName => Name + " " + Surname;
    }
}
