using System;
using System.Collections.Generic;
using System.Text;
using AbpAngularExample.Localization;
using Volo.Abp.Application.Services;

namespace AbpAngularExample;

/* Inherit your application services from this class.
 */
public abstract class AbpAngularExampleAppService : ApplicationService
{
    protected AbpAngularExampleAppService()
    {
        LocalizationResource = typeof(AbpAngularExampleResource);
    }
}
