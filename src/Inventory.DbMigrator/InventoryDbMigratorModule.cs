using Inventory.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Inventory.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(InventoryEntityFrameworkCoreModule),
    typeof(InventoryApplicationContractsModule)
    )]
public class InventoryDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
