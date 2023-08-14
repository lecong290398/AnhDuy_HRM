using System.Collections.Generic;
using AnhDuyCompany.ManagerCompany.Editions;
using AnhDuyCompany.ManagerCompany.Editions.Dto;
using AnhDuyCompany.ManagerCompany.MultiTenancy.Payments;
using AnhDuyCompany.ManagerCompany.MultiTenancy.Payments.Dto;

namespace AnhDuyCompany.ManagerCompany.Web.Models.Payment
{
    public class BuyEditionViewModel
    {
        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public decimal? AdditionalPrice { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}
