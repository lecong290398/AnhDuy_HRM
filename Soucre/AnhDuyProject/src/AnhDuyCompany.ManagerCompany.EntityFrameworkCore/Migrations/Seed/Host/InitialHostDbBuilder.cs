using AnhDuyCompany.ManagerCompany.EntityFrameworkCore;

namespace AnhDuyCompany.ManagerCompany.Migrations.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly ManagerCompanyDbContext _context;

        public InitialHostDbBuilder(ManagerCompanyDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
