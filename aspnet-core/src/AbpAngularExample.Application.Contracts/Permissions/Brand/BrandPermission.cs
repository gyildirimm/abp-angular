using System;
using System.Collections.Generic;
using System.Text;

namespace AbpAngularExample.Permissions.Brand
{
    public static class BrandPermission
    {
        public const string GroupName = "Brand";

        public static class Brand
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
