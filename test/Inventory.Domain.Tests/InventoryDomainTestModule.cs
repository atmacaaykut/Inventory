using Inventory.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Inventory;

[DependsOn(
    typeof(InventoryEntityFrameworkCoreTestModule)
    )]
public class InventoryDomainTestModule : AbpModule
{

}
