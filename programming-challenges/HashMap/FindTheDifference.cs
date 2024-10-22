namespace programming_challenges.HashMap;

public class FindTheDifference
{
    // https://leetcode.com/problems/find-the-difference/
    public char FindTheDifferenceSolution(string s, string t) {
        var charCount = new Dictionary<char, int>(); 

        foreach (char c in s) {
            if (charCount.ContainsKey(c)) {
                charCount[c]++;
            } else {
                charCount[c] = 1;
            }
        }

        foreach (char c in t) {
            if (charCount.ContainsKey(c)) {
                charCount[c]--;
                
                if (charCount[c] == 0) {
                    charCount.Remove(c);
                }
            } else {
                return c;
            }
        }

        return '\0';
    }
}