using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace test.abc.EntityFrameworkCore
{
    [DependsOn(
        typeof(abcEntityFrameworkCoreModule)
        )]
    public class abcEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<abcMigrationsDbContext>();
        }
    }
}
