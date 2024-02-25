using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Retrohof.Pages;

public class Index_Tests : RetrohofWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
