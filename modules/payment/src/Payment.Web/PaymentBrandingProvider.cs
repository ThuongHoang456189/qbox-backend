using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Payment.Web;

[Dependency(ReplaceServices = true)]
public class PaymentBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Payment";
}
