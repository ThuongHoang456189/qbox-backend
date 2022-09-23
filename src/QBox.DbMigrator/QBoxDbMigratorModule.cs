using QBox.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace QBox.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(QBoxEntityFrameworkCoreModule),
    typeof(QBoxApplicationContractsModule)
    )]
public class QBoxDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
