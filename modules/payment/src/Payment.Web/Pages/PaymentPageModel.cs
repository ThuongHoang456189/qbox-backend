using Payment.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Payment.Web.Pages;

public abstract class PaymentPageModel : AbpPageModel
{
    protected PaymentPageModel()
    {
        LocalizationResourceType = typeof(PaymentResource);
    }
}
