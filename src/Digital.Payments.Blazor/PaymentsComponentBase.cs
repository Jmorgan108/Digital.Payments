using Digital.Payments.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Digital.Payments.Blazor;

public abstract class PaymentsComponentBase : AbpComponentBase
{
    protected PaymentsComponentBase()
    {
        LocalizationResource = typeof(PaymentsResource);
    }
}
