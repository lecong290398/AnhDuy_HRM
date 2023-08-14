using Abp.Web.Models.AbpUserConfiguration;

namespace AnhDuyCompany.ManagerCompany.Configuration
{
    public static class AbpUserConfigurationDtoExtensions
    {
        public static bool HasSessionUserId(this AbpUserConfigurationDto userConfiguration)
        {
            return userConfiguration.Session?.UserId != null;
        }
    }
}