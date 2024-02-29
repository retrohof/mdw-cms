using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Volo.Abp.MultiTenancy;

namespace Mdw.Web;

//[Dependency(ReplaceServices = true)]
//public class MdwBrandingProvider : DefaultBrandingProvider
//{
//    public override string AppName => "Mdw";
//}

[Dependency(ReplaceServices = true)]
public class MdwBrandingProvider : DefaultBrandingProvider
{
    private readonly ICurrentTenant _currentTenant;
    public override string AppName => _currentTenant.Name ?? "CustomHost";

    public MdwBrandingProvider(ICurrentTenant currentTenant)
    {
        _currentTenant = currentTenant;
    }
}