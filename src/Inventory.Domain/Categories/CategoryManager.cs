using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using Volo.Abp.Domain.Services;

namespace Inventory.Categories
{
    public class CategoryManager : DomainService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<Category> GetCatByName([NotNull] string name)
        {
            return await _categoryRepository.GetCategoryByName(name);
        }
    }
}
