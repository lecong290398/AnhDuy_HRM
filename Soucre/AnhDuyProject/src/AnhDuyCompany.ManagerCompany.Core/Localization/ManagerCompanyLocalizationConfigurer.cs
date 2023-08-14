using System.Reflection;
using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace AnhDuyCompany.ManagerCompany.Localization
{
    public static class ManagerCompanyLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(
                    ManagerCompanyConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ManagerCompanyLocalizationConfigurer).GetAssembly(),
                        "AnhDuyCompany.ManagerCompany.Localization.ManagerCompany"
                    )
                )
            );
        }
    }
}