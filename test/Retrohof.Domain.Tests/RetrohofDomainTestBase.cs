using Volo.Abp.Modularity;

namespace Retrohof;

/* Inherit from this class for your domain layer tests. */
public abstract class RetrohofDomainTestBase<TStartupModule> : RetrohofTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
