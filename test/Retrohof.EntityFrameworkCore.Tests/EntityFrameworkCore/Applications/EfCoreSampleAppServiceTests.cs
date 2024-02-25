using Retrohof.Samples;
using Xunit;

namespace Retrohof.EntityFrameworkCore.Applications;

[Collection(RetrohofTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<RetrohofEntityFrameworkCoreTestModule>
{

}
