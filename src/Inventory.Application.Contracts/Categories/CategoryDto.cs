using System;
using Volo.Abp.Application.Dtos;

namespace Inventory.Categories
{
    public class CategoryDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
    }
}
