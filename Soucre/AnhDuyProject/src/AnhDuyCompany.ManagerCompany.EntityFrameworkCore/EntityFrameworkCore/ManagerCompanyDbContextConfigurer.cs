using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AnhDuyCompany.ManagerCompany.EntityFrameworkCore
{
    public static class ManagerCompanyDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ManagerCompanyDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ManagerCompanyDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}