namespace programming_challenges.HashMap;

public class ValidAnagram
{
    // https://leetcode.com/problems/valid-anagram/
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }

        var charCount = new Dictionary<char, int>();

        foreach (var x in s) {
            if (charCount.ContainsKey(x)) {
                charCount[x]++;
            } else {
                charCount[x] = 1;
            }
        }

        foreach (var z in t) {
            if (charCount.ContainsKey(z)) {
                charCount[z]--;
                if (charCount[z] < 0) {
                    return false;
                }
            } else {
                return false;
            }
        }

        return true;
    }
}