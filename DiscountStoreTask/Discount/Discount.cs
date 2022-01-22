namespace DiscountStoreTask
{
    class Discount
    {
        public int GetDiscount(int amount)
        {
            if (amount == 2) 
            {
                return 25;
            }
            if (amount == 3)
            {
                return 33;
            }
            if (amount >= 4)
            {
                return 40;
            }
            return 0;
        }
    }
}
