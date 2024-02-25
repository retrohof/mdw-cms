using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Mdw.Web;

[Dependency(ReplaceServices = true)]
public class MdwBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Mdw";
}
