using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class FewestCoins
    {
        static int MAXCHARSNO = 256;

        static int maxUniqueChars(string str, int n)
        {
            int[] count = new int[MAXCHARSNO];
            for (int i = 0; i < n; i++)
            {
                count[str[i]]++;
            }

            int max_unique = 0;
            for (int i = 0; i < MAXCHARSNO; i++)
            {
                if (count[i] != 0)
                {
                    max_unique++;
                }
            }

            return max_unique;
        }

        public static int fewestCoins(string coins)
        {
            int len = coins.Length;
            int min = len;
            int max_unique = maxUniqueChars(coins, len);

            for (int i = 0; i < len; i++)
            {
                for (int j = i; j < len; j++)
                {
                    string subs = string.Empty;

                    if (i < j)
                    {
                        subs = coins.Substring(i, coins.Length - j);
                    }
                    else
                    {
                        subs = coins.Substring(j, coins.Length - i);
                    }

                    int sub_len = subs.Length;
                    int sub_unigue_chars = maxUniqueChars(subs, sub_len);

                    if (sub_len < min && max_unique == sub_unigue_chars)
                    {
                        min = sub_len;
                    }
                }
            }

            return min;
        }

        static void Main(string[] args)
        {
            int result = fewestCoins("bab");
            Console.WriteLine(result);

        }
    }
}
