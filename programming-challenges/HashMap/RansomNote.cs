namespace programming_challenges.HashMap;

public class RansomNote
{
    // https://leetcode.com/problems/ransom-note/
    public bool CanConstruct(string ransomNote, string magazine) {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        
        // Populate the dictionary with characters from the magazine
        foreach(var m in magazine) {
            // If the character is already in the dictionary, increment its count
            if (dict.ContainsKey(m)) {
                dict[m]++;
            } else {
                // If the character is not in the dictionary, add it with a count of 1
                dict[m] = 1;
            }
        }

        // Iterate through the ransom note and check against the dictionary
        foreach(var r in ransomNote) {
            // If the character exists in the dictionary, decrement its count
            if(dict.ContainsKey(r)) {
                dict[r]--; 

                // If the count goes below zero, it means the magazine has fewer of this character than needed
                if (dict[r] < 0) {
                    return false;
                }
            } else {
                // If the character does not exist in the dictionary, the magazine does not have this character
                return false;
            }
        }

        // If we reach here, it means all characters in the ransom note can be constructed from the magazine
        return true;
    }
}