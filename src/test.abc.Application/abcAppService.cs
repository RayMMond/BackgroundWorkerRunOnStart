using System;
using System.Collections.Generic;
using System.Text;
using test.abc.Localization;
using Volo.Abp.Application.Services;

namespace test.abc
{
    /* Inherit your application services from this class.
     */
    public abstract class abcAppService : ApplicationService
    {
        protected abcAppService()
        {
            LocalizationResource = typeof(abcResource);
        }
    }
}
