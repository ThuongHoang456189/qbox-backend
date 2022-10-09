using System;
using System.Collections.Generic;
using System.Text;
using Payment.Localization;
using Volo.Abp.Application.Services;

namespace Payment;

/* Inherit your application services from this class.
 */
public abstract class PaymentAppService : ApplicationService
{
    protected PaymentAppService()
    {
        LocalizationResource = typeof(PaymentResource);
    }
}
