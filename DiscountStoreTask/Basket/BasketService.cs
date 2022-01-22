using System;
using System.Collections.Generic;
using System.Linq;

namespace DiscountStoreTask
{
    class BasketService : IBasketService
    {
        readonly private List<BasketItem> _purchases = new List<BasketItem>();

        public void Add(Item item, int amount = 1)
        {
            if (item == null) 
            {
                throw new NullReferenceException(nameof(item));
            }

            if (amount <= 0)
            {
                throw new ArgumentException(nameof(amount) + " must be greater than 0");
            }

            var basketItem = _purchases.FirstOrDefault(x => x.Id == item.Id);
            if(basketItem == null)
            {
                basketItem = new BasketItem { Id = item.Id };
                _purchases.Add(basketItem);
            }
            basketItem.Sku = item.Sku;
            basketItem.Cost = item.Cost;
            basketItem.IsDiscount = item.IsDiscount;
            basketItem.Amount+=amount;
        }

        public void Remove(Item item, int amount = 1) 
        {
            if (item == null)
            {
                throw new NullReferenceException(nameof(item));
            }

            if (amount <= 0)
            {
                throw new ArgumentException(nameof(amount) + " must be greater than 0");
            }

            var basketItem = _purchases.FirstOrDefault(x => x.Id == item.Id);
            if (basketItem.Amount <= amount)
            {
                _purchases.Remove(basketItem);
            }
            else basketItem.Amount -= amount;
        } 

        public decimal GetTotal()
        {
            Discount discount = new Discount();
            decimal total = 0;
            foreach (var item in _purchases)
            {
                int discoutInPercent = 0;
                if (item.IsDiscount)
                {
                    discoutInPercent = discount.GetDiscount(item.Amount);
                }
                total += item.Cost * (100 - discoutInPercent) / 100 * item.Amount;

                Console.WriteLine($"{item.Id} {item.Sku}: {item.Cost}$ - {item.Amount}");
            }
            Console.WriteLine("\nИтого:");
            return total;
        }
    }
}
