using System;

namespace DiscountStoreTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();
            BasketService basket = new BasketService();

            catalog._catalog[1].IsDiscount = true;

            Random rnd = new Random();

            foreach (var item in catalog._catalog)
            {
                basket.Add(item, rnd.Next(1, 4));
            }

            basket.Remove(catalog._catalog[0], 2);

            Console.WriteLine(basket.GetTotal());
            Console.ReadKey();
        }
    }
}
