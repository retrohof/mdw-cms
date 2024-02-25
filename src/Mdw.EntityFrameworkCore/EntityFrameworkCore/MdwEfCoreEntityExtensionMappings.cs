using Microsoft.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.ObjectExtending;
using Volo.Abp.TenantManagement;
using Volo.Abp.Threading;

namespace Mdw.EntityFrameworkCore;

public static class MdwEfCoreEntityExtensionMappings
{
    private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();

    public static void Configure()
    {
        MdwGlobalFeatureConfigurator.Configure();
        MdwModuleExtensionConfigurator.Configure();

        ObjectExtensionManager.Instance
            .MapEfCoreProperty<Tenant, string>(Constant.Host);
    }
}
