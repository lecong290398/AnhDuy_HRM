using System.Collections.Generic;
using Abp.Application.Services.Dto;
using AnhDuyCompany.ManagerCompany.Editions.Dto;

namespace AnhDuyCompany.ManagerCompany.Web.Areas.AppAreaName.Models.Common
{
    public interface IFeatureEditViewModel
    {
        List<NameValueDto> FeatureValues { get; set; }

        List<FlatFeatureDto> Features { get; set; }
    }
}