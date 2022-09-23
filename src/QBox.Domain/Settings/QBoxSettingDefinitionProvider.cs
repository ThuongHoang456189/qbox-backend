using Volo.Abp.Settings;

namespace QBox.Settings;

public class QBoxSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(QBoxSettings.MySetting1));
    }
}
