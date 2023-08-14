using System.Collections.Generic;
using AnhDuyCompany.ManagerCompany.Caching.Dto;

namespace AnhDuyCompany.ManagerCompany.Web.Areas.AppAreaName.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public IReadOnlyList<CacheDto> Caches { get; set; }
        
        public bool CanClearAllCaches { get; set; }
    }
}