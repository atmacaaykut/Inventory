using Inventory.Categories;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Inventory.Products
{
    public class ProductDto: AuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public CategoryDto Category { get; set; }
    }
}
