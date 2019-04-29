namespace free_market_model
{
    public class Buyer
    {
        public int MinPrice { get; set; }
        public int MaxPrice { get; set; }

        public bool Deal(Buyer buyer)
        {
            // 1. compare price - if price range is in both Seller and Buyer expectations then deal and
            // Seller will slightly increase min-price
            return true;
        }
    }
}