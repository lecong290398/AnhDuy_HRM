using AnhDuyCompany.ManagerCompany.Dto;

namespace AnhDuyCompany.ManagerCompany.Organizations.Dto
{
    public class FindOrganizationUnitUsersInput : PagedAndFilteredInputDto
    {
        public long OrganizationUnitId { get; set; }
    }
}
