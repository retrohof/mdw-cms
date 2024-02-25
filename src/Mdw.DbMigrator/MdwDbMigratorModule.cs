using Mdw.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Mdw.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(MdwEntityFrameworkCoreModule),
    typeof(MdwApplicationContractsModule)
    )]
public class MdwDbMigratorModule : AbpModule
{
}
