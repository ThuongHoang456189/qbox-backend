using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using QBox.Data;
using Volo.Abp.DependencyInjection;

namespace QBox.EntityFrameworkCore;

public class EntityFrameworkCoreQBoxDbSchemaMigrator
    : IQBoxDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreQBoxDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the QBoxDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<QBoxDbContext>()
            .Database
            .MigrateAsync();
    }
}
