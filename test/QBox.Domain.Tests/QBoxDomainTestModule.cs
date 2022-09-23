using QBox.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace QBox;

[DependsOn(
    typeof(QBoxEntityFrameworkCoreTestModule)
    )]
public class QBoxDomainTestModule : AbpModule
{

}
