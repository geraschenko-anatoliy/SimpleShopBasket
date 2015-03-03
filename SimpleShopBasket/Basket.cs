using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleShopBasket
{
    public class Basket
    {
        public static Dictionary<char, Func<int, decimal>> Rules { get; set; }
        static Dictionary<char, int> Products { get; set; }

        public Basket(string productList)
        {
            Products = new Dictionary<char, int>();
            foreach (char product in productList.Distinct())
            {
                Products.Add(product, Regex.Matches(productList, product.ToString()).Count);
            }
        }

        public decimal GetOverallPrice()
        {
            decimal result = 0;
            foreach (var item in Products.Keys)
            {
                result += Rules[item](Products[item]);
            }

            if (Rules.Count == Products.Count)
                result = result * (decimal)0.95;

            return result;
        }
    }
}
