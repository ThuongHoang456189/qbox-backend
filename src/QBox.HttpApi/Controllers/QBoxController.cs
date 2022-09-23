using QBox.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace QBox.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class QBoxController : AbpControllerBase
{
    protected QBoxController()
    {
        LocalizationResource = typeof(QBoxResource);
    }
}
