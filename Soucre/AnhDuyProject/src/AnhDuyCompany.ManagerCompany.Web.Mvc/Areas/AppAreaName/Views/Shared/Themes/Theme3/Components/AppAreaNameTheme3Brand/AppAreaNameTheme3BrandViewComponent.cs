﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AnhDuyCompany.ManagerCompany.Web.Areas.AppAreaName.Models.Layout;
using AnhDuyCompany.ManagerCompany.Web.Session;
using AnhDuyCompany.ManagerCompany.Web.Views;

namespace AnhDuyCompany.ManagerCompany.Web.Areas.AppAreaName.Views.Shared.Themes.Theme3.Components.AppAreaNameTheme3Brand
{
    public class AppAreaNameTheme3BrandViewComponent : ManagerCompanyViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppAreaNameTheme3BrandViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var headerModel = new HeaderViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(headerModel);
        }
    }
}
