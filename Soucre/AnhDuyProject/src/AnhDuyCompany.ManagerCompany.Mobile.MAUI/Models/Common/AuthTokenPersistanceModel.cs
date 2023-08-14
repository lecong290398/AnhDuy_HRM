using Abp.AutoMapper;
using AnhDuyCompany.ManagerCompany.Sessions.Dto;

namespace AnhDuyCompany.ManagerCompany.Models.Common
{
    [AutoMapFrom(typeof(ApplicationInfoDto)),
     AutoMapTo(typeof(ApplicationInfoDto))]
    public class ApplicationInfoPersistanceModel
    {
        public string Version { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}