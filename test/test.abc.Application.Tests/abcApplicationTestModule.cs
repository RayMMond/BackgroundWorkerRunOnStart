using Volo.Abp.Modularity;

namespace test.abc
{
    [DependsOn(
        typeof(abcApplicationModule),
        typeof(abcDomainTestModule)
        )]
    public class abcApplicationTestModule : AbpModule
    {

    }
}