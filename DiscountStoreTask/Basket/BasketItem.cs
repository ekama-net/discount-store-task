namespace DiscountStoreTask
{
    class BasketItem
    {
        public int Id { get; set; }
        public string Sku { get; set; }
        public decimal Cost { get; set; }
        public bool IsDiscount { get; set; }
        public int Amount { get; set; }
    }
}
