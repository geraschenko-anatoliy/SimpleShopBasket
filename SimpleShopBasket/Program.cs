using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShopBasket
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Basket.Rules = new Dictionary<char, Func<int, decimal>>();
            Basket.Rules.Add('A', (count) =>
            {
                if (count <= 3)
                    return 10 * count;
                if (count <= 7)
                    return 9 * count;
                return 8 * count;
            });

            Basket.Rules.Add('B', (count) =>
            {
                if (count <= 5)
                    return 20 * count;
                return 16 * count;
            });

            Basket.Rules.Add('C', (count) =>
            {
                return 6 * count;
            });

            Basket.Rules.Add('D', (count) =>
            {
                return (decimal)5.5 * count;
            });

            string inputLine = Console.ReadLine();

            Basket basket = new Basket(inputLine);

            Console.WriteLine(basket.GetOverallPrice());
            Console.ReadLine();
        }
    }
}
