using test.abc.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace test.abc.Permissions
{
    public class abcPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(abcPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(abcPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<abcResource>(name);
        }
    }
}
