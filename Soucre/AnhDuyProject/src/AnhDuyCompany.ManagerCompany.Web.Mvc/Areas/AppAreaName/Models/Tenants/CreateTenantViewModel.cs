﻿using System.Collections.Generic;
using AnhDuyCompany.ManagerCompany.Editions.Dto;
using AnhDuyCompany.ManagerCompany.Security;

namespace AnhDuyCompany.ManagerCompany.Web.Areas.AppAreaName.Models.Tenants
{
    public class CreateTenantViewModel
    {
        public IReadOnlyList<SubscribableEditionComboboxItemDto> EditionItems { get; set; }

        public PasswordComplexitySetting PasswordComplexitySetting { get; set; }

        public CreateTenantViewModel(IReadOnlyList<SubscribableEditionComboboxItemDto> editionItems)
        {
            EditionItems = editionItems;
        }
    }
}