using AnhDuyCompany.ManagerCompany.Editions.Dto;

namespace AnhDuyCompany.ManagerCompany.MultiTenancy.Payments.Dto
{
    public class PaymentInfoDto
    {
        public EditionSelectDto Edition { get; set; }

        public decimal AdditionalPrice { get; set; }

        public bool IsLessThanMinimumUpgradePaymentAmount()
        {
            return AdditionalPrice < ManagerCompanyConsts.MinimumUpgradePaymentAmount;
        }
    }
}
