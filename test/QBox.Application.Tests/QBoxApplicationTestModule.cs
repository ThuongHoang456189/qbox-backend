using Volo.Abp.Modularity;

namespace QBox;

[DependsOn(
    typeof(QBoxApplicationModule),
    typeof(QBoxDomainTestModule)
    )]
public class QBoxApplicationTestModule : AbpModule
{

}
