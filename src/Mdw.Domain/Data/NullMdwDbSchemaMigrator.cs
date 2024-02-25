using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Mdw.Data;

/* This is used if database provider does't define
 * IMdwDbSchemaMigrator implementation.
 */
public class NullMdwDbSchemaMigrator : IMdwDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
