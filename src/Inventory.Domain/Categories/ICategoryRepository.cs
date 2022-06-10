using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Inventory.Categories
{
    public interface ICategoryRepository : IRepository<Category, Guid>
    {
        Task<Category> GetCategoryByName(string name);
    }
}
