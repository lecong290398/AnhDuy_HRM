using System.Collections.Generic;

namespace AnhDuyCompany.ManagerCompany.MultiTenancy.Payments
{
    public interface IPaymentGatewayStore
    {
        List<PaymentGatewayModel> GetActiveGateways();
    }
}
