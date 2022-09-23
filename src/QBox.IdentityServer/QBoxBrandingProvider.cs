using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace QBox;

[Dependency(ReplaceServices = true)]
public class QBoxBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "QBox";
}
