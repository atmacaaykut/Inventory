using System;

namespace Inventory.Products
{
    public class CreateUpdateProductDto
    {
        public string Name { get; set; }
        public Guid CategoryId { get; set; }
    }
}
