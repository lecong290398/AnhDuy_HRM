using Abp.AutoMapper;
using AnhDuyCompany.ManagerCompany.Authorization.Users.Dto;

namespace AnhDuyCompany.ManagerCompany.Mobile.MAUI.Models.User
{
    [AutoMapFrom(typeof(CreateOrUpdateUserInput))]
    public class UserCreateOrUpdateModel : CreateOrUpdateUserInput
    {

    }
}
