using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class HourglassSum
    {
        static int hourglassSum(int[][] arr)
        {
            int result = 0;

            for (int i = 0; i < 4; i++)
            {

                for (int j = 0; j < 4; j++)
                {
                    int pivot = 0;

                    pivot += arr[i + 0][j + 0];
                    pivot += arr[i + 0][j + 1];
                    pivot += arr[i + 0][j + 2];

                    pivot += arr[i + 1][j + 1];

                    pivot += arr[i + 2][j + 0];
                    pivot += arr[i + 2][j + 1];
                    pivot += arr[i + 2][j + 2];

                    if (pivot > result)
                    {
                        result = pivot;
                    }
                }
            }

            return result;
        }

        static void Main(string[] args)
        {

            int result = 0;
            int[][] arr = new int[6][];

            arr[0] = new int[6] { 1, 1, 1, 0, 0, 0 };
            arr[1] = new int[6] { 0, 1, 0, 0, 0, 0 };
            arr[2] = new int[6] { 1, 1, 1, 0, 0, 0 };
            arr[3] = new int[6] { 0, 0, 2, 4, 4, 0 };
            arr[4] = new int[6] { 0, 0, 0, 2, 0, 0 };
            arr[5] = new int[6] { 0, 0, 1, 2, 4, 0 };


            result = hourglassSum(arr); // 19
            Console.WriteLine(result);


            arr[0] = new int[6] { 1, 1, 1, 0, 0, 0 };
            arr[1] = new int[6] { 0, 1, 0, 0, 0, 0 };
            arr[2] = new int[6] { 1, 1, 1, 0, 0, 0 };
            arr[3] = new int[6] { 0, 9, 2, -4, -4, 0 };
            arr[4] = new int[6] { 0, 0, 0, -2, 0, 0 };
            arr[5] = new int[6] { 0, 0, -1, -2, -4, 0 };

            result = hourglassSum(arr); // 13
            Console.WriteLine(result);


            arr[0] = new int[6] { -9, -9, -9, 1, 1, 1 };
            arr[1] = new int[6] { 0, -9, 0, 4, 3, 2 };
            arr[2] = new int[6] { -9, -9, -9, 1, 2, 3 };
            arr[3] = new int[6] { 0, 0, 8, 6, 6, 0 };
            arr[4] = new int[6] { 0, 0, 0, -2, 0, 0 };
            arr[5] = new int[6] { 0, 0, 1, 2, 4, 0 };


            result = hourglassSum(arr); // 28
            Console.WriteLine(result);
        }
    }
}
