using System;

namespace free_market_model
{
    public class Buyer
    {
        public Guid Id { get; }
        public int MinPrice { get; set; }
        public int MaxPrice { get; set; }

        public Buyer(int minAcceptablePrice, int maxAcceptablePrice)
        {
            Id = Guid.NewGuid();
            MinPrice = minAcceptablePrice;
            MaxPrice = maxAcceptablePrice;
        }

        public override string ToString()
        {
            return $"{Id.ToString().ToLower()} - {this.MinPrice} - {this.MaxPrice}";
        }
    }
}