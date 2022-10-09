using Payment.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Payment;

[DependsOn(
    typeof(PaymentEntityFrameworkCoreTestModule)
    )]
public class PaymentDomainTestModule : AbpModule
{

}
