using Volo.Abp.Modularity;

namespace Retrohof;

[DependsOn(
    typeof(RetrohofDomainModule),
    typeof(RetrohofTestBaseModule)
)]
public class RetrohofDomainTestModule : AbpModule
{

}
