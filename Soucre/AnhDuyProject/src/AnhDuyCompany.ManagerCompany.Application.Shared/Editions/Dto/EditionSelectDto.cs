﻿using System.Collections.Generic;
using AnhDuyCompany.ManagerCompany.MultiTenancy.Payments;

namespace AnhDuyCompany.ManagerCompany.Editions.Dto
{
    public class EditionSelectDto
    {
        public int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual string DisplayName { get; set; }

        public int? ExpiringEditionId { get; set; }

        public decimal? DailyPrice { get; set; }

        public decimal? WeeklyPrice { get; set; }

        public decimal? MonthlyPrice { get; set; }

        public decimal? AnnualPrice { get; set; }

        public int? TrialDayCount { get; set; }

        public int? WaitingDayAfterExpire { get; set; }

        public bool IsFree { get; set; }

        public EditionSelectDto()
        {
        }

        public decimal GetPaymentAmount(PaymentPeriodType? paymentPeriodType)
        {
            switch (paymentPeriodType)
            {
                case PaymentPeriodType.Daily:
                    return DailyPrice ?? 0;
                case PaymentPeriodType.Weekly:
                    return WeeklyPrice ?? 0;
                case PaymentPeriodType.Monthly:
                    return MonthlyPrice ?? 0;
                case PaymentPeriodType.Annual:
                    return AnnualPrice ?? 0;
                default:
                    return 0;
            }
        }
    }
}