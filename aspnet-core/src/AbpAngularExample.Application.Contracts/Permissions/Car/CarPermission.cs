using System;
using System.Collections.Generic;
using System.Text;

namespace AbpAngularExample.Permissions.Car
{
    public static class CarPermission
    {
        public const string GroupName = "Car";

        public static class Car
        {
            public const string Default = GroupName + ".Request";
            public const string Create = GroupName + ".Create";
            public const string Edit = GroupName + ".Edit";
            public const string Delete = GroupName + ".Delete";
            public const string Approve = GroupName + ".Approve";
            public const string Reject = GroupName + ".Reject";
        }
    }
}
