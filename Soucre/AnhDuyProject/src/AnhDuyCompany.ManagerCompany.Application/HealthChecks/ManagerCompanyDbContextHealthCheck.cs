using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using AnhDuyCompany.ManagerCompany.EntityFrameworkCore;

namespace AnhDuyCompany.ManagerCompany.HealthChecks
{
    public class ManagerCompanyDbContextHealthCheck : IHealthCheck
    {
        private readonly DatabaseCheckHelper _checkHelper;

        public ManagerCompanyDbContextHealthCheck(DatabaseCheckHelper checkHelper)
        {
            _checkHelper = checkHelper;
        }

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            if (_checkHelper.Exist("db"))
            {
                return Task.FromResult(HealthCheckResult.Healthy("ManagerCompanyDbContext connected to database."));
            }

            return Task.FromResult(HealthCheckResult.Unhealthy("ManagerCompanyDbContext could not connect to database"));
        }
    }
}
