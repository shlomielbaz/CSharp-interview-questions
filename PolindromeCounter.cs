using System;

namespace ConsoleApp1
{
    public class PolindromeCounter
    {
        public static int isPalindrom(string s)
        {
            int len = s.Length;
            int jdx = len - 1;

            char[] arr = s.ToCharArray();

            for (int idx = 0; idx < len && idx < jdx;)
            {
                if (arr[idx] != arr[jdx])
                {
                    return 0;
                }
                idx++;
                jdx--;
            }

            return 1;
        }

        public static int countPalindromes(string s)
        {
            int counter = 0;
            if (string.IsNullOrEmpty(s))
            {
                return counter;
            }

            int len = s.Length;

            // aabsbsbaa
            // i = 0, j = 1, s = a, returns = 1
            // i = 0, j = 2, s = aa, returns = 1
            // i = 0, j = 3, s = aab, returns = 0

            for (int i = 0; i < len; i++)
            {
                for (int j = 1; j <= (len - i); j++)
                {
                    counter += isPalindrom(s.Substring(i, j));
                }
            }

            return counter;
        }

        static void Main(string[] args)
        {
            int result = countPalindromes("aabsbsbaffa");
            Console.WriteLine(result);

        }
    }
}
