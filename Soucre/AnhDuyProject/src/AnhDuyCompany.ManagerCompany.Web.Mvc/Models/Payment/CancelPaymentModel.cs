﻿using AnhDuyCompany.ManagerCompany.MultiTenancy.Payments;

namespace AnhDuyCompany.ManagerCompany.Web.Models.Payment
{
    public class CancelPaymentModel
    {
        public string PaymentId { get; set; }

        public SubscriptionPaymentGatewayType Gateway { get; set; }
    }
}