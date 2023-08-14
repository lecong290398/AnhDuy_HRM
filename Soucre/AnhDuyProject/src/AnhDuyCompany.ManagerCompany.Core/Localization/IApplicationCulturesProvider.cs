using System.Globalization;

namespace AnhDuyCompany.ManagerCompany.Localization
{
    public interface IApplicationCulturesProvider
    {
        CultureInfo[] GetAllCultures();
    }
}