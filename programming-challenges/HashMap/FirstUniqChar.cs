namespace programming_challenges.HashMap;

public class FirstUniqChar
{
    // https://leetcode.com/problems/first-unique-character-in-a-string/
    public int FirstUniqCharSolution(string s) {
        var charCount = new Dictionary<char, int>();

        foreach(var data in s) {
            if(charCount.ContainsKey(data)) 
                charCount[data] += 1;
            else
                charCount[data] = 1;
        }

        for (var i = 0; i < s.Length; i++) {
            if(charCount[s[i]] == 1) {
                return i;
            }
        }

        return -1;
    }
}