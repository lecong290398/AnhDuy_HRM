using System.Collections.Generic;
using Abp.Localization;
using AnhDuyCompany.ManagerCompany.Install.Dto;

namespace AnhDuyCompany.ManagerCompany.Web.Models.Install
{
    public class InstallViewModel
    {
        public List<ApplicationLanguage> Languages { get; set; }

        public AppSettingsJsonDto AppSettingsJson { get; set; }
    }
}
