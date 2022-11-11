using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Digital.Payments.Blazor;

[Dependency(ReplaceServices = true)]
public class PaymentsBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Payments";
}
