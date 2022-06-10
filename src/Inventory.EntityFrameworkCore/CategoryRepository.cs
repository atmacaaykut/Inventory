using Inventory.Categories;
using Inventory.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Inventory
{
    public class CategoryRepository : EfCoreRepository<InventoryDbContext, Category, Guid>, ICategoryRepository
    {
        public CategoryRepository(IDbContextProvider<InventoryDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }

        public async Task<Category> GetCategoryByName(string name)
        {
            var dbSet = await GetDbSetAsync();
            return await dbSet.FirstOrDefaultAsync(x => x.Name == name);
        }
    }
}
