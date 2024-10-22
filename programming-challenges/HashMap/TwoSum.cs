namespace programming_challenges.HashMap;

public class TwoSum
{
    // https://leetcode.com/problems/two-sum/description/
    public int[] TwoSumSolution(int[] nums, int target) {
        var dic1 = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++) {
            var difference = target - nums[i];

            if (dic1.ContainsKey(difference)) {
                return new int[] { dic1[difference], i };
            }

            dic1[nums[i]] = i;
        }

        return new int[] {0};
    }
}