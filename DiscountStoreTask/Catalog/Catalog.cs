using System.Collections.Generic;

namespace DiscountStoreTask
{
    class Catalog
    {
        public readonly List<Item> _catalog = new List<Item>
        {
            new Item
            {
                Id = 1, 
                Sku = "Vase", 
                Cost = 1.2M, 
                IsDiscount = false
            },
            new Item
            {
                Id = 2, 
                Sku = "Big mug", 
                Cost = 1M, 
                IsDiscount = false 
            },
            new Item
            {
                Id = 3,
                Sku = "Napkins pack", 
                Cost = 0.45M, 
                IsDiscount = false 
            }
        };
    }
}
