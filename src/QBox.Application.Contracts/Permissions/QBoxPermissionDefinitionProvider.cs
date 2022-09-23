using QBox.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace QBox.Permissions;

public class QBoxPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(QBoxPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(QBoxPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<QBoxResource>(name);
    }
}
