using Volo.Abp.Settings;

namespace Mdw.Settings;

public class MdwSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(MdwSettings.MySetting1));
    }
}
