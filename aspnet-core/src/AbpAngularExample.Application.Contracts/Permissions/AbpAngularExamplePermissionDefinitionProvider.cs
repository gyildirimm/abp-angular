using AbpAngularExample.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpAngularExample.Permissions;

public class AbpAngularExamplePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AbpAngularExamplePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AbpAngularExamplePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AbpAngularExampleResource>(name);
    }
}
