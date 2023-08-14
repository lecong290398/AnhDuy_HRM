using Microsoft.Extensions.DependencyInjection;
using AnhDuyCompany.ManagerCompany.HealthChecks;

namespace AnhDuyCompany.ManagerCompany.Web.HealthCheck
{
    public static class AbpZeroHealthCheck
    {
        public static IHealthChecksBuilder AddAbpZeroHealthCheck(this IServiceCollection services)
        {
            var builder = services.AddHealthChecks();
            builder.AddCheck<ManagerCompanyDbContextHealthCheck>("Database Connection");
            builder.AddCheck<ManagerCompanyDbContextUsersHealthCheck>("Database Connection with user check");
            builder.AddCheck<CacheHealthCheck>("Cache");

            // add your custom health checks here
            // builder.AddCheck<MyCustomHealthCheck>("my health check");

            return builder;
        }
    }
}
