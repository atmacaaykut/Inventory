using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Inventory.Products
{
    public class ProductAppService : CrudAppService<Product, ProductDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateProductDto, Guid>
    {
        public ProductAppService(IRepository<Product, Guid> repository) : base(repository)
        {
        }

    }
}
