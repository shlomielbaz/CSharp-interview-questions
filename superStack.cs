using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void superStack(string[] operations)
        {
            List<int> stack = new List<int>();

            Regex push = new Regex(@"push (\d+)$");
            Regex inc = new Regex(@"inc (\d+) (\d+)$");

            int len = operations.Length;
            for (int idx = 0; idx < len; idx++)
            {
                Match push_match = push.Match(operations[idx]);
                Match inc_match = inc.Match(operations[idx]);
                string item = operations[idx];

                if (push_match.Success)
                {
                    int v = int.Parse(push_match.Groups[1].Value);
                    stack.Add(v);
                }
                else if (inc_match.Success)
                {
                    int i = int.Parse(inc_match.Groups[1].Value);
                    int v = int.Parse(inc_match.Groups[2].Value);

                    for (int jdx = 0; jdx < i; jdx++)
                    {
                        stack[jdx] = stack[jdx] + v;
                    }
                }
                else if (item == "pop")
                {
                    int pos = (stack.Count - 1);
                    int v = stack[pos];
                    stack.RemoveAt(pos);
                }

                if (stack.Count == 0)
                {
                    Console.WriteLine("EMPTY");
                }
                else
                {
                    int pos = (stack.Count - 1);
                    Console.WriteLine(stack[pos]);
                }
            }
        }

        static void Main(string[] args)
        {
            string[] operations = new string[12] {
                "push 4",
                "pop",
                "push 3",
                "push 5",
                "push 2",
                "inc 3 1",
                "pop",
                "push 1",
                "inc 2 2",
                "push 4",
                "pop",
                "pop"
            };

            superStack(operations);
        }
    }
}
