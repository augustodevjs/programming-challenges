namespace programming_challenges.HashMap;

public class ContainsNearbyDuplicate
{
    // https://leetcode.com/problems/contains-duplicate-ii/
    public bool ContainsNearbyDuplicateSolution(int[] nums, int k) {
        var dic1 = new Dictionary<int, int>();

        for(var i = 0; i < nums.Length; i++) {
            if(dic1.ContainsKey(nums[i])) {
                int previousIndex = dic1[nums[i]];

                if (Math.Abs(i - previousIndex) <= k) {
                    return true;
                }
            } 

            dic1[nums[i]] = i;
        }

        return false;
    }
}