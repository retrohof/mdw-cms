using System;
using System.Collections.Generic;
using System.Text;
using Mdw.Localization;
using Volo.Abp.Application.Services;

namespace Mdw;

/* Inherit your application services from this class.
 */
public abstract class MdwAppService : ApplicationService
{
    protected MdwAppService()
    {
        LocalizationResource = typeof(MdwResource);
    }
}
