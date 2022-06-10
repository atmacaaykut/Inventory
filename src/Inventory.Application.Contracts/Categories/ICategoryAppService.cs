using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Inventory.Categories
{
    public interface ICategoryAppService : IApplicationService
    {
        Task<CategoryDto> GetCategoryByName(string name);
    }
}
