using AnhDuyCompany.ManagerCompany.Editions;
using AnhDuyCompany.ManagerCompany.Editions.Dto;
using AnhDuyCompany.ManagerCompany.MultiTenancy.Payments;
using AnhDuyCompany.ManagerCompany.Security;
using AnhDuyCompany.ManagerCompany.MultiTenancy.Payments.Dto;

namespace AnhDuyCompany.ManagerCompany.Web.Models.TenantRegistration
{
    public class TenantRegisterViewModel
    {
        public PasswordComplexitySetting PasswordComplexitySetting { get; set; }

        public int? EditionId { get; set; }

        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }
    }
}
