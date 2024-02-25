using Mdw.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Mdw.Permissions;

public class MdwPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(MdwPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(MdwPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<MdwResource>(name);
    }
}
