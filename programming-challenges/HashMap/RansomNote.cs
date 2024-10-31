namespace programming_challenges.HashMap;

public class RansomNote
{
    // https://leetcode.com/problems/ransom-note/
    public bool CanConstruct(string ransomNote, string magazine) {
        var letterCount = new Dictionary<char, int>();

        foreach (var m in magazine) { 
            if (!letterCount.ContainsKey(m)) {
                letterCount[m] = 1;
            } else {
                letterCount[m] += 1;
            }
        }

        foreach (var r in ransomNote) {
            if(letterCount.ContainsKey(r) && letterCount[r] != 0) { 
                letterCount[r] -= 1;
            } else {
                return false;
            }
        }

        return true;
    }
}