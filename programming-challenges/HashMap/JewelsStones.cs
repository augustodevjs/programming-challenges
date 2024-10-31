namespace programming_challenges.HashMap;

public class JewelsStones
{
    // https://leetcode.com/problems/jewels-and-stones/
    public int NumJewelsInStones(string jewels, string stones) {
        var jewelSet = new HashSet<char>(jewels);
        var count = 0;
        
        foreach (var stone in stones) {
            if (jewelSet.Contains(stone)) {
                count++;
            }
        }

        return count;
    }
}