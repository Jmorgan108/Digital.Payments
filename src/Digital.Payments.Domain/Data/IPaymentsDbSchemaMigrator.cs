using System.Threading.Tasks;

namespace Digital.Payments.Data;

public interface IPaymentsDbSchemaMigrator
{
    Task MigrateAsync();
}
