using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace test.abc.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(abcHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class abcConsoleApiClientModule : AbpModule
    {
        
    }
}
