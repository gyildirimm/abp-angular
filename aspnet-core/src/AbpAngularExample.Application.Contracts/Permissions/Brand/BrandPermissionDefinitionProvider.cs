using AbpAngularExample.Localization;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpAngularExample.Permissions.Brand
{
    public class BrandPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var bookStoreGroup = context.AddGroup(BrandPermission.GroupName, L("Permission:Brand"));

            var booksPermission = bookStoreGroup.AddPermission(BrandPermission.Brand.Default, L("Permission:Brand.Request"));
            booksPermission.AddChild(BrandPermission.Brand.Create, L("Permission:Brand.Create"));
            booksPermission.AddChild(BrandPermission.Brand.Edit, L("Permission:Brand.Edit"));
            booksPermission.AddChild(BrandPermission.Brand.Delete, L("Permission:Brand.Delete"));
            booksPermission.AddChild(BrandPermission.Brand.Approve, L("Permission:Brand.Approve"));
            booksPermission.AddChild(BrandPermission.Brand.Reject, L("Permission:Brand.Reject"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AbpAngularExampleResource>(name);
        }
    }
}
