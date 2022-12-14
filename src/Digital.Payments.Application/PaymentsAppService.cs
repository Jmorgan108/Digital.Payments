using System;
using System.Collections.Generic;
using System.Text;
using Digital.Payments.Localization;
using Volo.Abp.Application.Services;

namespace Digital.Payments;

/* Inherit your application services from this class.
 */
public abstract class PaymentsAppService : ApplicationService
{
    protected PaymentsAppService()
    {
        LocalizationResource = typeof(PaymentsResource);
    }
}
