using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpAngularExample.Data;
using Volo.Abp.DependencyInjection;

namespace AbpAngularExample.EntityFrameworkCore;

public class EntityFrameworkCoreAbpAngularExampleDbSchemaMigrator
    : IAbpAngularExampleDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAbpAngularExampleDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the AbpAngularExampleDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AbpAngularExampleDbContext>()
            .Database
            .MigrateAsync();
    }
}
