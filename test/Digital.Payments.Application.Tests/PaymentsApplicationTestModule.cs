using Volo.Abp.Modularity;

namespace Digital.Payments;

[DependsOn(
    typeof(PaymentsApplicationModule),
    typeof(PaymentsDomainTestModule)
    )]
public class PaymentsApplicationTestModule : AbpModule
{

}
