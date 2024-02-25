using Retrohof.Samples;
using Xunit;

namespace Retrohof.EntityFrameworkCore.Domains;

[Collection(RetrohofTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<RetrohofEntityFrameworkCoreTestModule>
{

}
