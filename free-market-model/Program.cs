using System;
using System.Collections.Generic;
using System.Linq;

namespace free_market_model
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> iterations = Enumerable.Range(0, Configuration.NUMBER_OF_ITERATIONS);
            IEnumerable<Seller> sellers = GetSellers(Configuration.NUMBER_OF_SELLERS);
            IEnumerable<Buyer> buyers = GetBuyers(Configuration.NUMBER_OF_BUYERS);
            foreach (int iteration in iterations)
            {
                //System.Console.WriteLine(iteration);
            }
        }

        static List<Seller> GetSellers(int count)
        {
            var list = new List<Seller>();

            for (int i = 0; i < count; i++)
            {

            }

            return list;
        }

        static List<Buyer> GetBuyers(int count)
        {
            return new List<Buyer>();
        }
    }
}