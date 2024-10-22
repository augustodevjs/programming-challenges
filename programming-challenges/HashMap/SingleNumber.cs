namespace programming_challenges.HashMap;

public class SingleNumber
{
    // https://leetcode.com/problems/single-number/
    public int SingleNumberSolution(int[] nums) {
        var dic1 = new Dictionary<int, int>();

        foreach(var num in nums) {
            if (!dic1.ContainsKey(num)) 
                dic1[num] = 1;
            else
                dic1[num] += 1;
        }

        foreach (var key in dic1.Keys){
            if (dic1[key] == 1) 
                return key;
        }

        return 0;
    }
}