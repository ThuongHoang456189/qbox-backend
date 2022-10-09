using Payment.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Payment.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(PaymentEntityFrameworkCoreModule),
    typeof(PaymentApplicationContractsModule)
    )]
public class PaymentDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
