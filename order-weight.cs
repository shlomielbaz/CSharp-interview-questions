using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class order_weight
    {
        static string weightSort(string strng)
        {
            string[] keys = strng.Split(" ");

            int len = keys.Length;

            List<KeyValuePair<string, int>> weights = new List<KeyValuePair<string, int>>();

            for (int idx = 0; idx < len; idx++)
            {
                string key = keys[idx];

                int value = 0;

                for (int jdx = 0; jdx < key.Length; jdx++)
                {
                    value += (int)key[jdx] - 48;
                }

                weights.Add(new KeyValuePair<string, int>(key, value));
            }

            string result = weights.OrderBy(x => x.Value)
                        .GroupBy(x => x.Value)
                        .Select(g => g.OrderBy(x => x.Key))
                        .SelectMany(x => x)
                        .Select(x => x.Key)
                        .Aggregate((a, b) => a + " " + b);

            // Console.WriteLine(result);
            // var groups = weights.OrderBy(x => x.Value).GroupBy(x => x.Value);
            // string result = string.Empty;
            // foreach (var group in groups)
            // {
            //    var list = group.OrderBy(x => x.Key).Select(x => x.Key);
            //    result += string.Join(" ", list) + " ";
            // }
            //Console.WriteLine(String.Join(" ", result.ToArray()));

            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(String.Format("2000 103 123 4444 99 === {0}", weightSort("103 123 4444 99 2000")));
            Console.WriteLine(String.Format("11 11 2000 10003 22 123 1234000 44444444 9999 === {0}", weightSort("2000 10003 1234000 44444444 9999 11 11 22 123")));
        }
    }
}
