using Volo.Abp.Settings;

namespace Digital.Payments.Settings;

public class PaymentsSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(PaymentsSettings.MySetting1));
    }
}
