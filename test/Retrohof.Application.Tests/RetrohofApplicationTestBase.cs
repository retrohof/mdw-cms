using Volo.Abp.Modularity;

namespace Retrohof;

public abstract class RetrohofApplicationTestBase<TStartupModule> : RetrohofTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
