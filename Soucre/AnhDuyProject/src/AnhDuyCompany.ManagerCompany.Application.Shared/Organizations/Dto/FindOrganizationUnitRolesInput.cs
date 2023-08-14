using AnhDuyCompany.ManagerCompany.Dto;

namespace AnhDuyCompany.ManagerCompany.Organizations.Dto
{
    public class FindOrganizationUnitRolesInput : PagedAndFilteredInputDto
    {
        public long OrganizationUnitId { get; set; }
    }
}