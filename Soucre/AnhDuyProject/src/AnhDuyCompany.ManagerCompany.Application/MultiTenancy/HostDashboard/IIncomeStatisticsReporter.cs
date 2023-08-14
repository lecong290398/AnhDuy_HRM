using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AnhDuyCompany.ManagerCompany.MultiTenancy.HostDashboard.Dto;

namespace AnhDuyCompany.ManagerCompany.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}