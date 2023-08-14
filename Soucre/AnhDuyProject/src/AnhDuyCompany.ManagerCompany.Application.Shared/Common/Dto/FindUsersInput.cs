using AnhDuyCompany.ManagerCompany.Dto;

namespace AnhDuyCompany.ManagerCompany.Common.Dto
{
    public class FindUsersInput : PagedAndFilteredInputDto
    {
        public int? TenantId { get; set; }

        public bool ExcludeCurrentUser { get; set; }
    }
}