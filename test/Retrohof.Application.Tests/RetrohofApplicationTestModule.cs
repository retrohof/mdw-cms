using Volo.Abp.Modularity;

namespace Retrohof;

[DependsOn(
    typeof(RetrohofApplicationModule),
    typeof(RetrohofDomainTestModule)
)]
public class RetrohofApplicationTestModule : AbpModule
{

}
