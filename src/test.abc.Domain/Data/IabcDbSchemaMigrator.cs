using System.Threading.Tasks;

namespace test.abc.Data
{
    public interface IabcDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
