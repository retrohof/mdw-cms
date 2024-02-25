using Mdw.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Mdw.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class MdwPageModel : AbpPageModel
{
    protected MdwPageModel()
    {
        LocalizationResourceType = typeof(MdwResource);
    }
}
