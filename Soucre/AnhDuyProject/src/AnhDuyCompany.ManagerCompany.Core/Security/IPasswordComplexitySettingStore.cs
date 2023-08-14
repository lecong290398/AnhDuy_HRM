using System.Threading.Tasks;

namespace AnhDuyCompany.ManagerCompany.Security
{
    public interface IPasswordComplexitySettingStore
    {
        Task<PasswordComplexitySetting> GetSettingsAsync();
    }
}
