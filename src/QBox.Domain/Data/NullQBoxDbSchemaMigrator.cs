using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace QBox.Data;

/* This is used if database provider does't define
 * IQBoxDbSchemaMigrator implementation.
 */
public class NullQBoxDbSchemaMigrator : IQBoxDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
