using Abp.Events.Bus;

namespace AnhDuyCompany.ManagerCompany.MultiTenancy
{
    public class RecurringPaymentsEnabledEventData : EventData
    {
        public int TenantId { get; set; }
    }
}