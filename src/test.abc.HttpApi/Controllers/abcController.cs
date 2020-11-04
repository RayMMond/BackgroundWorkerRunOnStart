using test.abc.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace test.abc.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class abcController : AbpController
    {
        protected abcController()
        {
            LocalizationResource = typeof(abcResource);
        }
    }
}