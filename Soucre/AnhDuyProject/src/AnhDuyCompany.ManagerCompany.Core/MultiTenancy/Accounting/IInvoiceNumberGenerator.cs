using System.Threading.Tasks;
using Abp.Dependency;

namespace AnhDuyCompany.ManagerCompany.MultiTenancy.Accounting
{
    public interface IInvoiceNumberGenerator : ITransientDependency
    {
        Task<string> GetNewInvoiceNumber();
    }
}