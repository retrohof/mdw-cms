using System.Threading.Tasks;

namespace Mdw.Data;

public interface IMdwDbSchemaMigrator
{
    Task MigrateAsync();
}
