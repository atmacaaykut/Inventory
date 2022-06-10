using Inventory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace Inventory.Categories
{
    public class Category : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
