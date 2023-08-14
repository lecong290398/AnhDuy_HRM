using System.Collections.Generic;
using AnhDuyCompany.ManagerCompany.Organizations.Dto;
using AnhDuyCompany.ManagerCompany.Web.Areas.AppAreaName.Models.Common;

namespace AnhDuyCompany.ManagerCompany.Web.Areas.AppAreaName.Models.OrganizationUnits
{
    public class OrganizationUnitLookupTableModel : IOrganizationUnitsEditViewModel
    {
        public List<OrganizationUnitDto> AllOrganizationUnits { get; set; }
        
        public List<string> MemberedOrganizationUnits { get; set; }

        public OrganizationUnitLookupTableModel()
        {
            AllOrganizationUnits = new List<OrganizationUnitDto>();
            MemberedOrganizationUnits = new List<string>();
        }
    }
}