using Microsoft.AspNetCore.Builder;
using Retrohof;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<RetrohofWebTestModule>();

public partial class Program
{
}
