using System.Threading.Tasks;

namespace QBox.Data;

public interface IQBoxDbSchemaMigrator
{
    Task MigrateAsync();
}
