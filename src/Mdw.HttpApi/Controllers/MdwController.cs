using Mdw.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Mdw.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class MdwController : AbpControllerBase
{
    protected MdwController()
    {
        LocalizationResource = typeof(MdwResource);
    }
}
