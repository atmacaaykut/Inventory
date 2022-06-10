using System.Threading.Tasks;

namespace Inventory.Categories
{
    public class CategoryAppService : InventoryAppService, ICategoryAppService

    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly CategoryManager _categoryManager;
        public CategoryAppService(ICategoryRepository categoryRepository, CategoryManager categoryManager)
        {
            _categoryRepository = categoryRepository;
            _categoryManager = categoryManager;
        }

        public async Task<CategoryDto> GetCategoryByName(string name)
        {

            var category = await _categoryRepository.GetCategoryByName(name);
            return ObjectMapper.Map<Category, CategoryDto>(category);
        }
    }
}
