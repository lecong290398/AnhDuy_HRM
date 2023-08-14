using System.Collections.Generic;
using AnhDuyCompany.ManagerCompany.DynamicEntityProperties.Dto;

namespace AnhDuyCompany.ManagerCompany.Web.Areas.AppAreaName.Models.DynamicProperty
{
    public class CreateOrEditDynamicPropertyViewModel
    {
        public DynamicPropertyDto DynamicPropertyDto { get; set; }

        public List<string> AllowedInputTypes { get; set; }
    }
}
