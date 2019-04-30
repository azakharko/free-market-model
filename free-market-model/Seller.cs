using System;

namespace free_market_model
{
    public class Seller
    {
        public Guid Id { get; }
        public int MinAcceptablePrice { get; set; }
        public int MaxAcceptablePrice { get; set; }

        public Seller(int minAcceptablePrice, int maxAcceptablePrice)
        {
            Id = Guid.NewGuid();
            MinAcceptablePrice = minAcceptablePrice;
            MaxAcceptablePrice = maxAcceptablePrice;
        }

        public override string ToString()
        {
            return $"{Id.ToString().ToLower()} - {this.MinAcceptablePrice} - {this.MaxAcceptablePrice}";
        }
    }
}