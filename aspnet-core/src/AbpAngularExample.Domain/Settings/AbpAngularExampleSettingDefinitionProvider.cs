using Volo.Abp.Settings;

namespace AbpAngularExample.Settings;

public class AbpAngularExampleSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AbpAngularExampleSettings.MySetting1));
    }
}
