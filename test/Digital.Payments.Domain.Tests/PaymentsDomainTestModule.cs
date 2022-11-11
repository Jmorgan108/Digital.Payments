using Digital.Payments.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Digital.Payments;

[DependsOn(
    typeof(PaymentsEntityFrameworkCoreTestModule)
    )]
public class PaymentsDomainTestModule : AbpModule
{

}
