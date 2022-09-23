using System;
using System.Collections.Generic;
using System.Text;
using QBox.Localization;
using Volo.Abp.Application.Services;

namespace QBox;

/* Inherit your application services from this class.
 */
public abstract class QBoxAppService : ApplicationService
{
    protected QBoxAppService()
    {
        LocalizationResource = typeof(QBoxResource);
    }
}
