using System;
namespace main
{

	public class XX
	{
        public static void Main(string[] args)
        {
            
            //var ar = new Arrays();
            //var st = new Strings();
            //var ll = new LinkedLists();

            var tr = new Trees();

            tr.Add(3);
            tr.Add(5);
            tr.Add(6);
            tr.Add(1);
            tr.Add(9);

            tr.print();



            //// Example to create a binary tree and find its maximum depth
            //TreeNode root = new TreeNode(1);
            //root.left = new TreeNode(2);
            //root.right = new TreeNode(3);
            //root.left.left = new TreeNode(4);
            //root.left.right = new TreeNode(5);
            //root.right.left = new TreeNode(6);
            //root.right.right = new TreeNode(7);


            //// Example to create a binary tree and check if it is a valid BST
            //TreeNode root2 = new TreeNode(2);
            //root2.left = new TreeNode(1);
            //root2.right = new TreeNode(3);



            //// Check if the binary tree is a valid BST

            //Console.WriteLine("Is Valid BST: " + tr.IsValidBST(root)); // Output should be tru
            //Console.WriteLine("Is Valid BST: " + tr.IsValidBST(root2)); // Output should be tru



            //// Find the maximum depth of the binary tree
            //int maxDepth = tr.MaxDepth(root);
            //Console.WriteLine("Maximum Depth: " + maxDepth); // Output


            //ll.add(5);
            //ll.add(1);
            //ll.add(9);
            //ll.add(8);
            //ll.add(2);
            //ll.add(3);
            //ll.add(7);

            //ll.print();
            //ll.reverse();
            //ll.print();


            //st.ReverseString(new char[] { 'H', 'e', 'l', 'l', 'o' });
            //Console.WriteLine(st.Reverse(-24350));


            //Console.WriteLine(st.FirstUniqChar("leetcode"));
            //Console.WriteLine(st.FirstUniqChar("loveleetcode"));
            //Console.WriteLine(st.FirstUniqChar("aabb"));

            //Console.WriteLine(st.IsPalindrome("A man, a plan, a canal: Panama"));
            //Console.WriteLine(st.IsPalindrome("race a car"));
            //Console.WriteLine(st.IsPalindrome(" "));


            //Console.WriteLine(st.MyAtoi(" -042"));
            //Console.WriteLine(st.MyAtoi("1337c0d3"));
            //Console.WriteLine(st.MyAtoi("0-1"));
            //Console.WriteLine(st.MyAtoi(""));

            // Remove Duplicates from Sorted Array
            //int[] nums1_1 = new int[] { 1, 1, 2 };
            //Console.WriteLine($"{Arrays.RemoveDuplicates(nums1_1)}");
            //int[] nums1_2 = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            //Console.WriteLine($"{Arrays.RemoveDuplicates(nums1_2)}");

            // Rotate Array
            // Rotate(new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 3);

            // Console.WriteLine($"{Arrays.ContainsDuplicate(new int[5] { 0, 1,2, 3, 4 })}");

            //int[] nums = { 4, 4, 1, 1, 2, 2, 3, 3, 5, 5, 6, 7, 7 };
            //Console.WriteLine("The single number is: " + Arrays.SingleNumber(nums));

            //int[] nums1 = { 1, 2, 2, 1 };
            //int[] nums2 = { 2, 2 };
            //Console.WriteLine("Intersection: " + string.Join(", ", Intersect(nums1, nums2))); // Output: 2, 2

            //int[] nums3 = { 4, 9, 5 };
            //int[] nums4 = { 9, 4, 9, 8, 4 };
            //Console.WriteLine("Intersection: " + string.Join(", ", Intersect(nums3, nums4))); // Output: 4, 9

            //Console.WriteLine("PlusOne Result: " + string.Join(", ", PlusOne(new int[] { 1, 2, 3 })));
            //Console.WriteLine("PlusOne Result: " + string.Join(", ", PlusOne(new int[] { 9, 9, 9 })));
            //Console.WriteLine("PlusOne Result: " + string.Join(", ", PlusOne(new int[] { 1, 9, 9, 9 })));
            //Console.WriteLine("PlusOne Result: " + string.Join(", ", PlusOne(new int[] { 1, 9, 7, 9 })));

            //var moveZeroes = new int[] { 0, 1, 0, 3, 12 };
            //MoveZeroes(moveZeroes);
            //Console.WriteLine("MoveZeroes Result: " + string.Join(", ", moveZeroes)); // Output: 1, 3, 12, 0, 0
            //Console.WriteLine("TwoSum Result: " + string.Join(",", TwoSum(new int[] { 2, 7, 11, 15 }, 9))); // Output: 1, 3, 12, 0, 0

            //Console.WriteLine(IsValidSudoku(new char[][] {
            //    new char[] {'5', '3', '.', '.', '7', '.', '.', '.', '.'},
            //    new char[] {'6', '.', '.', '1', '9', '5', '.', '.', '.'},
            //    new char[] {'.', '9', '8', '.', '.', '.', '.', '6', '.'},
            //    new char[] {'8', '.', '.', '.', '6', '.', '.', '.', '3'},
            //    new char[] {'4', '.', '.', '8', '.', '3', '.', '.', '1'},
            //    new char[] {'7', '.', '.', '.', '2', '.', '.', '.', '6'},
            //    new char[] {'.', '6', '.', '.', '.', '.', '2', '8', '.'},
            //    new char[] {'.', '.', '.', '4', '1', '9', '.', '.', '5'},
            //    new char[] {'.', '.', '.', '.', '8', '.', '.', '7', '9'}
            //}));


            //Console.WriteLine(IsValidSudoku(new char[][]{
            //    new char[]{'8','3','.','.','7','.','.','.','.'},
            //    new char[]{'6','.','.','1','9','5','.','.','.'},
            //    new char[]{'.','9','8','.','.','.','.','6','.'},
            //    new char[]{'8','.','.','.','6','.','.','.','3'},
            //    new char[]{'4','.','.','8','.','3','.','.','1'},
            //    new char[]{'7','.','.','.','2','.','.','.','6'},
            //    new char[]{'.','6','.','.','.','.','2','8','.'},
            //    new char[]{'.','.','.','4','1','9','.','.','5'},
            //    new char[]{'.','.','.','.','8','.','.','7','9'}
            //}));

            //int[][] matrix = new int[][] {
            //    new int[] { 1, 2, 3},
            //    new int[] { 4, 5, 6},
            //    new int[] { 7, 8, 9}
            //};
            //Rotate(matrix);
            //Console.WriteLine();

            Concurency.run();
        }
    }
}

