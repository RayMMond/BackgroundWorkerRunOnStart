using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace test.abc
{
    [Dependency(ReplaceServices = true)]
    public class abcBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "abc";
    }
}
