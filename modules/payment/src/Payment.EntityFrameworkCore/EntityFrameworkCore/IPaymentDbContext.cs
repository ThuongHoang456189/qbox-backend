using Microsoft.EntityFrameworkCore;
using Payment.PaymentRequests;
using Volo.Abp.EntityFrameworkCore;

namespace Payment.EntityFrameworkCore
{
    public interface IPaymentDbContext : IEfCoreDbContext
    {
        DbSet<PaymentRequest> PaymentRequests { get; }
    }
}
