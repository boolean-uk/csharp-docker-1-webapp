using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace exercise.wwwapp.Data
{

    public static class ProductHelper
    {
        public static Dictionary<int, string> Products { get; set; } = new Dictionary<int, string>();
        public static Dictionary<int, int> StockCountToProductMap { get; set; } = new Dictionary<int, int>();
        public static void Create(string product)
        {
            Products.Add(Products.Max(x => x.Key) + 1, product);

        }
        public static void Read()
        {
            Console.WriteLine("");

            foreach (var kvp in Products)
            {
                Console.WriteLine($"{kvp.Key}.{kvp.Value}");
            }
        }
        
        public static void Delete(int id)
        {
            //remove from the stock map
            StockCountToProductMap.Remove(id);
            
            //remove from the product dictionary
            Products.Remove(id);
        }
        public static void Initialize()
        {
            Products.Add(1,"Boolean Branded Hoodie (Size M)");
            Products.Add(2,"Boolean Branded Mouse Mat");
            
            Products.Add(3,"Official Boolean Duck");
            StockCountToProductMap.Add(3, 1000);

            Products.Add(4,"Boolean Sticker");

        }
        public static int GetStockValueFromProductId(int id)
        {
            if(!StockCountToProductMap.ContainsKey(id))
            {
                StockCountToProductMap.Add(id, 0);
            }
            return StockCountToProductMap[id];                   
        }
        public static void StockIncrement(int id)
        {
            if (StockCountToProductMap.ContainsKey(id))
            {
                StockCountToProductMap[id] = StockCountToProductMap[id] + 1;
            }
            else
            {
                StockCountToProductMap.Add(id, 1);
            }
        }

        public static void StockDecrement(int id)
        {
            if (StockCountToProductMap.ContainsKey(id))
            {
                if (StockCountToProductMap[id] > 0)
                {
                    StockCountToProductMap[id] = StockCountToProductMap[id] - 1;
                }

            }            
        }
    }
}