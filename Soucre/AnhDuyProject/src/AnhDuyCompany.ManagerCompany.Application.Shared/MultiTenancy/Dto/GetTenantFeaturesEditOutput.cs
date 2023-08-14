using System.Collections.Generic;
using Abp.Application.Services.Dto;
using AnhDuyCompany.ManagerCompany.Editions.Dto;

namespace AnhDuyCompany.ManagerCompany.MultiTenancy.Dto
{
    public class GetTenantFeaturesEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}