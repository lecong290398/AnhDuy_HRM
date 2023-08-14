using AnhDuyCompany.ManagerCompany.Models.NavigationMenu;

namespace AnhDuyCompany.ManagerCompany.Services.Navigation
{
    public interface IMenuProvider
    {
        List<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}