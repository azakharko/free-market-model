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

            // foreach (int iteration in iterations)
            // {
            //     System.Console.WriteLine(rnd.Next(0, 100));
            // }

           foreach (var item in sellers)
           {
               Console.WriteLine(item);
           }
        }

        static List<Seller> GetSellers(int count)
        {
            Random rnd = new Random();
            var startPrice = 75;

            var list = new List<Seller>();

            for (int i = 0; i < count; i++)
            {
                list.Add(new Seller(startPrice - rnd.Next(0, 25), startPrice + rnd.Next(0, 25)));
            }

            return list;
        }

        static List<Buyer> GetBuyers(int count)
        {
            return new List<Buyer>();
        }
    }
}