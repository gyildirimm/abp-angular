using AbpAngularExample.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpAngularExample.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AbpAngularExampleController : AbpControllerBase
{
    protected AbpAngularExampleController()
    {
        LocalizationResource = typeof(AbpAngularExampleResource);
    }
}
