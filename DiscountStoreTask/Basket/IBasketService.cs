namespace DiscountStoreTask
{
    interface IBasketService
    {
        void Add(Item item,int amount);
        void Remove(Item item, int amount);
        decimal GetTotal();
    }
}
