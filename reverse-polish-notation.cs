using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Class1
    {
        static double calcEvaluate(string str)
        {
            if (str == "")
            {
                return 0;
            }

            string[] calcs = str.Split(" ");

            int len = calcs.Length;

            Stack<double> stack = new Stack<double>();

            for (int i = 0; i < len; i++)
            {
                try
                {
                    double result = double.Parse(calcs[i]);
                    stack.Push(result);
                }
                catch (FormatException)
                {
                    double b = stack.Pop();
                    double a = stack.Pop();
                    double result = 0;

                    switch (calcs[i])
                    {
                        case "+":
                            result = a + b;
                            break;

                        case "-":
                            result = a - b;
                            break;

                        case "*":
                            result = a * b;
                            break;

                        case "/":
                            result = a / b;
                            break;
                    }

                    stack.Push(result);
                }
            }

            return stack.Pop();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(calcEvaluate(""));
            Console.WriteLine(calcEvaluate("1 2 3"));
            Console.WriteLine(calcEvaluate("1 2 3.5"));
            Console.WriteLine(calcEvaluate("1 3 +"));
            Console.WriteLine(calcEvaluate("1 3 *"));
            Console.WriteLine(calcEvaluate("1 3 -"));
            Console.WriteLine(calcEvaluate("4 2 /"));
            Console.WriteLine(calcEvaluate("5 1 2 + 4 * + 3 -"));
        }
    }
}
