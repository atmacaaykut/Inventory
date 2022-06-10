using AutoMapper;
using Inventory.Categories;
using Inventory.Products;

namespace Inventory;

public class InventoryApplicationAutoMapperProfile : Profile
{
    public InventoryApplicationAutoMapperProfile()
    {
        CreateMap<Category, CategoryDto>();

        CreateMap<CreateUpdateCategoryDto, Category>();

        CreateMap<Product, ProductDto>();

        CreateMap<CreateUpdateProductDto, Product>();


        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
