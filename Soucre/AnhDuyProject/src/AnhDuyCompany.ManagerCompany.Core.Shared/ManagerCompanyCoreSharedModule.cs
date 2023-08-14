﻿using Abp.Modules;
using Abp.Reflection.Extensions;

namespace AnhDuyCompany.ManagerCompany
{
    public class ManagerCompanyCoreSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ManagerCompanyCoreSharedModule).GetAssembly());
        }
    }
}