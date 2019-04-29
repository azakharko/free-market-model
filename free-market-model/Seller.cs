using System;

namespace free_market_model
{
    public class Seller
    {
        public Guid Id { get; }
        public int MinAcceptablePrice { get; set; }
        public int MaxAcceptablePrice { get; set; }

        public Seller()
        {
            Id = Guid.NewGuid();
        }

        public override string ToString()
        {
            return Id.ToString().ToLower();
        }
    }
}