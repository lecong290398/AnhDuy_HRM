﻿using System.Collections.Generic;
using AnhDuyCompany.ManagerCompany.Editions.Dto;
using AnhDuyCompany.ManagerCompany.MultiTenancy.Payments;

namespace AnhDuyCompany.ManagerCompany.Web.Models.Payment
{
    public class UpgradeEditionViewModel
    {
        public EditionSelectDto Edition { get; set; }

        public PaymentPeriodType PaymentPeriodType { get; set; }

        public SubscriptionPaymentType SubscriptionPaymentType { get; set; }

        public decimal? AdditionalPrice { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}