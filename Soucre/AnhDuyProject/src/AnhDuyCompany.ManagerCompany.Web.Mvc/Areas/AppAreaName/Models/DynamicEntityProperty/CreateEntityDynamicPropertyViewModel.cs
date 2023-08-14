using System.Collections.Generic;
using AnhDuyCompany.ManagerCompany.DynamicEntityProperties.Dto;

namespace AnhDuyCompany.ManagerCompany.Web.Areas.AppAreaName.Models.DynamicEntityProperty
{
    public class CreateEntityDynamicPropertyViewModel
    {
        public string EntityFullName { get; set; }

        public List<string> AllEntities { get; set; }

        public List<DynamicPropertyDto> DynamicProperties { get; set; }
    }
}
