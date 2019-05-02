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

            foreach (var item in sellers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            sellers = sellers.Shuffle();

            foreach (var item in sellers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            sellers = sellers.Shuffle();

            foreach (var item in sellers)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        static List<Seller> GetSellers(int count)
        {
            var list = new List<Seller>();

            for (int i = 0; i < count; i++)
            {
                list.Add(new Seller(Configuration.START_PRICE - R.GetValue(25), Configuration.START_PRICE + R.GetValue(25)));
            }

            return list;
        }

        static List<Buyer> GetBuyers(int count)
        {
            var list = new List<Buyer>();

            for (int i = 0; i < count; i++)
            {
                list.Add(new Buyer(Configuration.START_PRICE - R.GetValue(25), Configuration.START_PRICE + R.GetValue(25)));
            }

            return list;
        }
    }

    public class R
    {
        private static Random random = new Random();
        public static  Double GetValue()
        {
            return random.NextDouble();
        }
        public static Int32 GetValue(int max)
        {
            return random.Next(0, max);
        }
    }

    public static class MyExtentions
    {
        private static Random rng = new Random();

        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> items)
        {
            var list = items.ToArray<T>();
            int n = list.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }

            return list;
        }
    }
}