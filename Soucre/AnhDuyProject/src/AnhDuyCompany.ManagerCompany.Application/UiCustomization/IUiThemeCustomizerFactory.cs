using System.Threading.Tasks;
using Abp.Dependency;

namespace AnhDuyCompany.ManagerCompany.UiCustomization
{
    public interface IUiThemeCustomizerFactory : ISingletonDependency
    {
        Task<IUiCustomizer> GetCurrentUiCustomizer();

        IUiCustomizer GetUiCustomizer(string theme);
    }
}