﻿using Microsoft.Extensions.Configuration;
using System.Reflection;
using AnhDuyCompany.ManagerCompany.Core;

namespace AnhDuyCompany.ManagerCompany.Mobile.MAUI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();
#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
#endif
            ApplicationBootstrapper.InitializeIfNeeds<ManagerCompanyMobileMAUIModule>();

            var app = builder.Build();
            return app;
        }
    }
}