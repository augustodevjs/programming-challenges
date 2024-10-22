namespace programming_challenges.HashMap;

public class LongestPalindrome
{
    // https://leetcode.com/problems/longest-palindrome/
    public int LongestPalindromeSolution(string s) {
        var charCount = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (charCount.ContainsKey(c))
                charCount[c]++;
            else
                charCount[c] = 1;
        }

        int length = 0;
        bool oddFound = false;

        foreach (int count in charCount.Values)
        {
            if (count % 2 == 0)
            {
                length += count;
            }
            else
            {
                length += count - 1;
                oddFound = true;
            }
        }

        if (oddFound)
            length += 1;

        return length;
    }
}