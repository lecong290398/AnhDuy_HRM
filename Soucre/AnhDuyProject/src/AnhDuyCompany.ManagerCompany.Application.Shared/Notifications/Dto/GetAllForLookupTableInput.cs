using Abp.Application.Services.Dto;

namespace AnhDuyCompany.ManagerCompany.Notifications.Dto
{
    public class GetAllForLookupTableInput : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }
}