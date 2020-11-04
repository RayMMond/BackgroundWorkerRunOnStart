using test.abc.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace test.abc
{
    [DependsOn(
        typeof(abcEntityFrameworkCoreTestModule)
        )]
    public class abcDomainTestModule : AbpModule
    {

    }
}