using System;

namespace ConsoleApp1
{
    class Program
    {
        static Tuple<int, int, int, int> smallestAmountOfBanknotes(int price)
        {
            int hundreds = (int)price / 100;

            price = price % 100;

            int fifty = (int)price / 50;

            price = price % 50;

            int tens = (int)price / 10;

            int unity = price % 10;

            return new Tuple<int, int, int, int>(hundreds, fifty, tens, unity);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(smallestAmountOfBanknotes(2056));
        }
    }
}
