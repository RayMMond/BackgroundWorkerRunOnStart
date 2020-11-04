using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace test.abc.Data
{
    /* This is used if database provider does't define
     * IabcDbSchemaMigrator implementation.
     */
    public class NullabcDbSchemaMigrator : IabcDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}