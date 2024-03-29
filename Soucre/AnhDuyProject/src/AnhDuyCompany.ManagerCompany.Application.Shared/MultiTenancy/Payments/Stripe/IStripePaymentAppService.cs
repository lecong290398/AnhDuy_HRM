﻿using System.Threading.Tasks;
using Abp.Application.Services;
using AnhDuyCompany.ManagerCompany.MultiTenancy.Payments.Dto;
using AnhDuyCompany.ManagerCompany.MultiTenancy.Payments.Stripe.Dto;

namespace AnhDuyCompany.ManagerCompany.MultiTenancy.Payments.Stripe
{
    public interface IStripePaymentAppService : IApplicationService
    {
        Task ConfirmPayment(StripeConfirmPaymentInput input);

        StripeConfigurationDto GetConfiguration();

        Task<SubscriptionPaymentDto> GetPaymentAsync(StripeGetPaymentInput input);

        Task<string> CreatePaymentSession(StripeCreatePaymentSessionInput input);
    }
}