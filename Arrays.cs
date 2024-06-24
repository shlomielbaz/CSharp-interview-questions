namespace main;
public class Arrays
{
    /*
        Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once. The relative order of the elements should be kept the same. Then return the number of unique elements in nums.

        Consider the number of unique elements of nums to be k, to get accepted, you need to do the following things:

        Change the array nums such that the first k elements of nums contain the unique elements in the order they were present in nums initially. The remaining elements of nums are not important as well as the size of nums.
        Return k.
        Custom Judge:

        The judge will test your solution with the following code:

        Example 1:
        Input: nums = [1,1,2]
        Output: 2, nums = [1,2,_]
        Explanation: Your function should return k = 2, with the first two elements of nums being 1 and 2 respectively.
        It does not matter what you leave beyond the returned k (hence they are underscores).
        Example 2:

        Input: nums = [0,0,1,1,1,2,2,3,3,4]
        Output: 5, nums = [0,1,2,3,4,_,_,_,_,_]
        Explanation: Your function should return k = 5, with the first five elements of nums being 0, 1, 2, 3, and 4 respectively.
        It does not matter what you leave beyond the returned k (hence they are underscores).
    */
    public static int RemoveDuplicates(int[] nums)
    {
        HashSet<int> visitedIds = new HashSet<int>();
        int?[] numsList = nums.Cast<int?>().ToArray();
        var k = 0;
        var idx = 0;
        while (idx < numsList.Length)
        {
            int? item = numsList[idx];
            if (item == null)
            {
                break;
            }
            else if(!visitedIds.Contains((int)item))
            {
                visitedIds.Add((int)item);
                idx = idx + 1;
            }
            else
            {
                k = idx + 1;
                int swapIdx = numsList.Length - idx;
                for (int i = idx; i < swapIdx; i++)
                {
                    numsList[i] = numsList[i+1];
                }
                numsList[swapIdx] = null;
            }
        }
        Console.WriteLine($"[{string.Join(",", numsList)}]");
        return k;
    }

    /*
        You are given an integer array prices where prices[i] is the price of a given stock on the ith day.
        On each day, you may decide to buy and/or sell the stock. You can only hold at most one share of the stock at any time. However, you can buy it then immediately sell it on the same day.
        Find and return the maximum profit you can achieve
    */
    public static int MaxProfit(int[] prices)
    {
        int maxProfit = 0;
        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] > prices[i - 1])
            {
                maxProfit += prices[i] - prices[i - 1];
            }
        }
        return maxProfit;
    }

    // Given an integer array nums, rotate the array to the right by k steps, where k is non-negative.
    public static void Rotate(int[] nums, int k)
    {
        int skip = nums.Length - k;
        var z = new int[nums.Length];
        nums.Skip(skip).Take(k).ToArray().CopyTo(z, 0);
        nums.Skip(0).Take(skip).ToArray().CopyTo(z, k);
        Console.WriteLine("[" + string.Join(",", z) + "]");
    }

    // Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
    public static bool ContainsDuplicate(int[] nums)
    {
        var list = new HashSet<int>(nums);
        return list.Count != nums.Length;
    }


    //Given a non-empty array of integers nums, every element appears twice except for one.Find that single one.
    //You must implement a solution with a linear runtime complexity and use only constant extra space.
    public static int SingleNumber(int[] nums)
    {
        int singleNumber = 0;
        foreach (int num in nums)
        {
            singleNumber ^= num;
        }
        return singleNumber;
    }

    // Given two integer arrays nums1 and nums2, return an array of their intersection.Each element in the result must appear as many times as it shows in both arrays and you may return the result in any order.
    public static int[] Intersect(int[] nums1, int[] nums2)
    {
        // Dictionary to store the counts of elements in nums1
        Dictionary<int, int> counts = new Dictionary<int, int>();
        List<int> intersection = new List<int>();
        // Count each element in nums1
        foreach (int num in nums1)
        {
            if (counts.ContainsKey(num))
            {
                counts[num]++;
            }
            else
            {
                counts[num] = 1;
            }
        }
        // Find common elements in nums2
        foreach (int num in nums2)
        {
            if (counts.ContainsKey(num) && counts[num] > 0)
            {
                intersection.Add(num);
                counts[num]--;
            }
        }
        return intersection.ToArray();
    }

    /*
     * You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer. The digits are ordered from most significant to least significant in left-to-right order. The large integer does not contain any leading 0's.
       Increment the large integer by one and return the resulting array of digits.
    */
    public static int[] PlusOne(int[] digits)
    {
        int n = digits.Length;
        // Start from the last digit and move towards the first
        for (int i = n - 1; i >= 0; i--)
        {
            if (digits[i] < 9)
            {
                digits[i]++;
                return digits;
            }
            // If the digit is 9, it becomes 0
            digits[i] = 0;
        }

        // If all digits are 9, we need an extra digit at the beginning
        int[] newDigits = new int[n + 1];
        newDigits[0] = 1; // The most significant digit will be 1
                          // The rest of newDigits are already 0 by default
        return newDigits;
    }

    /*
     * Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
     * Note that you must do this in-place without making a copy of the array.
     */
    public static void MoveZeroes(int[] nums)
    {
        int nonZeroPosition = 0;
        // Move all non-zero elements to the beginning of the array
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[nonZeroPosition] = nums[i];
                nonZeroPosition++;
            }
        }
        // Fill the rest of the array with zeros
        for (int i = nonZeroPosition; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
    }

    /*
        Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        You may assume that each input would have exactly one solution, and you may not use the same element twice.
        You can return the answer in any order.
    */
    public static int[] TwoSum(int[] nums, int target)
    {
        for(int i = 0; i<nums.Length; i++)
        {
            for (int j = i+1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }

            }
        }
        return new int[0];
    }


    /*
        Determine if a 9 x 9 Sudoku board is valid. Only the filled cells need to be validated according to the following rules:

        Each row must contain the digits 1-9 without repetition.
        Each column must contain the digits 1-9 without repetition.
        Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.
        Note:

        A Sudoku board (partially filled) could be valid but is not necessarily solvable.
        Only the filled cells need to be validated according to the mentioned rules.
    */
    public static bool IsValidSudoku(char[][] board)
    {
        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] columns = new HashSet<char>[9];
        HashSet<char>[] boxes = new HashSet<char>[9];

        for (int i = 0; i < 9; i++)
        {
            rows[i] = new HashSet<char>();
            columns[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }

        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                char num = board[i][j];

                if (num != '.')
                {
                    // Check the row
                    if (rows[i].Contains(num))
                    {
                        return false;
                    }
                    rows[i].Add(num);

                    // Check the column
                    if (columns[j].Contains(num))
                    {
                        return false;
                    }
                    columns[j].Add(num);

                    // Check the box
                    int boxIndex = (i / 3) * 3 + j / 3;
                    if (boxes[boxIndex].Contains(num))
                    {
                        return false;
                    }
                    boxes[boxIndex].Add(num);
                }
            }
        }
        return true;
    }

    /*
        You are given an n x n 2D matrix representing an image, rotate the image by 90 degrees (clockwise).
        You have to rotate the image in-place, which means you have to modify the input 2D matrix directly. DO NOT allocate another 2D matrix and do the rotation.
    */
    public static void Rotate(int[][] matrix)
    {
        int len = matrix.Length - 1;
        int[][] image = new int[matrix.Length][];

        for (int i = len; i >= 0; i--)
        {
            image[i] = new int[matrix.Length];
            int idx = 0;
            for (int j = len; j >= 0; j--)
            {
                image[i][idx] = matrix[j][i];
                idx = idx + 1;
            }
        }

        for(int i = 0; i < matrix.Length; i++)
        {
            Console.WriteLine($"{string.Join(",", image[i])}");
        }
    }
}
