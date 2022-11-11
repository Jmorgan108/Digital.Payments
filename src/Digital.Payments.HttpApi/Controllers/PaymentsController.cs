using Digital.Payments.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Digital.Payments.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class PaymentsController : AbpControllerBase
{
    protected PaymentsController()
    {
        LocalizationResource = typeof(PaymentsResource);
    }
}
