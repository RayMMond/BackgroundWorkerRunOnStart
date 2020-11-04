using Volo.Abp.Settings;

namespace test.abc.Settings
{
    public class abcSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(abcSettings.MySetting1));
        }
    }
}
