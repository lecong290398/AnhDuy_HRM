using Abp.AutoMapper;
using AnhDuyCompany.ManagerCompany.Organizations.Dto;

namespace AnhDuyCompany.ManagerCompany.Mobile.MAUI.Models.User
{
    [AutoMapFrom(typeof(OrganizationUnitDto))]
    public class OrganizationUnitModel : OrganizationUnitDto
    {
        public bool IsAssigned { get; set; }
    }
}
