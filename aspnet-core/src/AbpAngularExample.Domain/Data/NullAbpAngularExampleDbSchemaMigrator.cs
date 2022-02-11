using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpAngularExample.Data;

/* This is used if database provider does't define
 * IAbpAngularExampleDbSchemaMigrator implementation.
 */
public class NullAbpAngularExampleDbSchemaMigrator : IAbpAngularExampleDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
