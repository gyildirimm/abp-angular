using AbpAngularExample.Localization;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpAngularExample.Permissions.Car
{

    public class CarPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var bookStoreGroup = context.AddGroup(CarPermission.GroupName, L("Permission:Car"));

            var booksPermission = bookStoreGroup.AddPermission(CarPermission.Car.Default, L("Permission:Car.Request"));
            booksPermission.AddChild(CarPermission.Car.Create, L("Permission:Car.Create"));
            booksPermission.AddChild(CarPermission.Car.Edit, L("Permission:Car.Edit"));
            booksPermission.AddChild(CarPermission.Car.Delete, L("Permission:Car.Delete"));
            booksPermission.AddChild(CarPermission.Car.Approve, L("Permission:Car.Approve"));
            booksPermission.AddChild(CarPermission.Car.Reject, L("Permission:Car.Reject"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AbpAngularExampleResource>(name);
        }
    }
}
