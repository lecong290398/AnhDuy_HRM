using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using AnhDuyCompany.ManagerCompany.MultiTenancy.Accounting.Dto;

namespace AnhDuyCompany.ManagerCompany.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
