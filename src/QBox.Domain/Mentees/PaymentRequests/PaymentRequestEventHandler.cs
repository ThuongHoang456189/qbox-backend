using Volo.Abp.DependencyInjection;
using Volo.Abp.EventBus.Distributed;

namespace QBox.Mentees.PaymentRequests
{
    public class PaymentRequestEventHandler : IDistributedEventHandler<PaymentRequestCompletedEto>,
        IDistributedEventHandler<PaymentRequestFailedEto>, ITransientDependency
    {
    }
}
