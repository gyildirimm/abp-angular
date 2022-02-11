using System.Threading.Tasks;

namespace AbpAngularExample.Data;

public interface IAbpAngularExampleDbSchemaMigrator
{
    Task MigrateAsync();
}
