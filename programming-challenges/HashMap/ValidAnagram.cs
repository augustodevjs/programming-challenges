namespace programming_challenges.HashMap;

public class ValidAnagram
{
    // https://leetcode.com/problems/valid-anagram/
    public bool IsAnagram(string s, string t) {
        // Check if the lengths of the strings are equal
        if (s.Length != t.Length) {
            return false;
        }
        
        // Create a dictionary to count the occurrences of each character in s
        var charCount = new Dictionary<char, int>();
        
        // Iterate through the first string and populate the dictionary
        foreach (var x in s) {
            if (charCount.ContainsKey(x)) {
                // If the character is already in the dictionary, increment its count
                charCount[x]++;
            } else {
                // If the character is not in the dictionary, add it with a count of 1
                charCount[x] = 1;
            }
        }

        // Iterate through the second string and check against the dictionary
        foreach (var z in t) {
            if (charCount.ContainsKey(z)) {
                // If the character exists in the dictionary, decrement its count
                charCount[z]--;
                if (charCount[z] < 0) {
                    // If the count goes below zero, it means t has more of this character than s
                    return false;
                }
            } else {
                // If the character does not exist in the dictionary, t has a character not in s
                return false;
            }
        }
        
        // If we reach here, it means all characters matched and counts are balanced
        return true;
    }
}