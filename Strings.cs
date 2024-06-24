using System.Text;
using System.Text.RegularExpressions;

namespace main;
public class Strings
{
    public void ReverseString(char[] s)
    {
        for(int i = s.Length-1; i>=0; i-- )
        {
            Console.Write($"{s[i]}");
        }
        Console.WriteLine("");
    }

    /*
        Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.
        Assume the environment does not allow you to store 64-bit integers (signed or unsigned).
    */
    public int Reverse(int x)
    {
        int reversed = 0;
        while (x != 0)
        {
            int pop = x % 10;

            x /= 10;

            reversed = reversed * 10 + pop;
        }
        return reversed;
    }

    /*
        Given a string s, find the first non-repeating character in it and return its index. If it does not exist, return -1.
    */
    public int FirstUniqChar(string s)
    {
        // Step 1: Count the occurrences of each character
        Dictionary<char, int> charCount = new Dictionary<char, int>();
        foreach (char c in s)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount[c] = 1;
            }
        }
        // Step 2: Find the first character with a count of 1
        for (int i = 0; i < s.Length; i++)
        {
            if (charCount[s[i]] == 1)
            {
                return i;
            }
        }
        // If no unique character found, return -1
        return -1;
    }


    /*
        Given two strings s and t, return true if t is an anagram of s, and false otherwise.
        An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
    */
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        int[] charCounts = new int[26]; // assuming the strings contain only lowercase letters

        // Count characters in the first string
        foreach (char c in s)
        {
            charCounts[c - 'a']++;
        }

        // Decrease counts for the second string
        foreach (char c in t)
        {
            charCounts[c - 'a']--;
        }

        // Check if all counts are zero
        foreach (int count in charCounts)
        {
            if (count != 0)
            {
                return false;
            }
        }
        return true;
    }

    /*
        A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.
        Given a string s, return true if it is a palindrome, or false otherwise.
    */
    public bool IsPalindrome(string s)
    {
        Regex rg = new Regex(@"[a-z]");
        StringBuilder str = new StringBuilder();
        foreach(char c in s)
        {
            string ss = char.ToString(c).ToLower();
            if (rg.Match(ss).Success)
            {
                str.Append(ss);
            }
        }
        int b = 0;
        char[] ar = str.ToString().ToArray();
        int e = ar.Length - 1;
        while (b < e)
        {
            if (ar[b] != ar[e])
            {
                return false;
            }

            b++;
            e--;
        }
        return true;
    }

    /*
        Implement the myAtoi(string s) function, which converts a string to a 32-bit signed integer.

        The algorithm for myAtoi(string s) is as follows:

        Whitespace: Ignore any leading whitespace (" ").
        Signedness: Determine the sign by checking if the next character is '-' or '+', assuming positivity is neither present.
        Conversion: Read the integer by skipping leading zeros until a non-digit character is encountered or the end of the string is reached. If no digits were read, then the result is 0.
        Rounding: If the integer is out of the 32-bit signed integer range [-231, 231 - 1], then round the integer to remain in the range. Specifically, integers less than -231 should be rounded to -231, and integers greater than 231 - 1 should be rounded to 231 - 1.
        Return the integer as the final result.
    */
    public int? MyAtoi(string s)
    {
        string pattern = @"^\s*?([-+])?([0-9]+)";
        Regex rg = new Regex(pattern);
        MatchCollection matchedAuthors = rg.Matches(s);
        StringBuilder str = new StringBuilder();
        foreach (var group in matchedAuthors)
        {
            str.Append(group);
        }
        return str.ToString() == "" ? null : int.Parse(str.ToString());
    }
}
