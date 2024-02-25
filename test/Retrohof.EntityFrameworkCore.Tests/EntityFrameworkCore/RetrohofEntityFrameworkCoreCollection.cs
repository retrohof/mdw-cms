using Xunit;

namespace Retrohof.EntityFrameworkCore;

[CollectionDefinition(RetrohofTestConsts.CollectionDefinitionName)]
public class RetrohofEntityFrameworkCoreCollection : ICollectionFixture<RetrohofEntityFrameworkCoreFixture>
{

}
