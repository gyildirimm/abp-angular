using AbpAngularExample.Localization;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpAngularExample.Permissions.Model
{

    public class ModelPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var bookStoreGroup = context.AddGroup(ModelPermission.GroupName, L("Permission:Model"));

            var booksPermission = bookStoreGroup.AddPermission(ModelPermission.Model.Default, L("Permission:Model.Request"));
            booksPermission.AddChild(ModelPermission.Model.Create, L("Permission:Model.Create"));
            booksPermission.AddChild(ModelPermission.Model.Edit, L("Permission:Model.Edit"));
            booksPermission.AddChild(ModelPermission.Model.Delete, L("Permission:Model.Delete"));
            booksPermission.AddChild(ModelPermission.Model.Approve, L("Permission:Model.Approve"));
            booksPermission.AddChild(ModelPermission.Model.Reject, L("Permission:Model.Reject"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AbpAngularExampleResource>(name);
        }
    }
}
