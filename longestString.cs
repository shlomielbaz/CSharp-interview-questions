using System;

namespace ConsoleApp1
{
    class Program
    {
        static void longestString(string str)
        {
            int len = str.Length;
            bool has_upper = false;
            int idx = 0;
            string holder = string.Empty;

            for (int i = 0; i < len; i++)
            {
                int asciiCode = (int)str[i];

                // if char is upper case 
                if (asciiCode >= 65 && asciiCode <= 90)
                {
                    has_upper = true;
                } 
                // if char is digit
                else if (asciiCode >= 48 && asciiCode <= 57)
                {
                    if (has_upper)
                    {
                        string pivot = str.Substring(idx, i - idx);
                        if (pivot.Length > holder.Length)
                        {
                            holder = pivot;
                        }
                    }
                    has_upper = false;
                    idx = i + 1;
                }
            }

            if (holder == string.Empty)
            {
                if (has_upper == true)
                {
                    Console.WriteLine(str);
                }
                else
                {
                    Console.WriteLine("The string dosen't contains uppercase char");
                }
            }
            else
            {
                Console.WriteLine(holder);
            }
        }

        static void Main(string[] args)
        {
            longestString("AF6kj shks fRk jh6sdjsfgsfWkj"); // prints: kj shks fRk jh
            longestString("kjhkjhkh akj hk"); // prints: The string dosen't contains uppercase char
            longestString("AS3kjhkjhkh akj hk"); // prints: AS
            longestString("333"); // prints: The string dosen't contains uppercase char
        }
    }
}
