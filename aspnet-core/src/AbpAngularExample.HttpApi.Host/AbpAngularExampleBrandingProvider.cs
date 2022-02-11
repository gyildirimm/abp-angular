using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AbpAngularExample;

[Dependency(ReplaceServices = true)]
public class AbpAngularExampleBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AbpAngularExample";
}
