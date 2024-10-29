namespace programming_challenges.Arrays.two_pointers;

public class ApplyOperationsToAnArray
{
    // https://leetcode.com/problems/apply-operations-to-an-array/
    public int[] ApplyOperations(int[] nums) {
        for (var i = 0; i < nums.Length - 1; i++) {
            if (nums[i] == nums[i + 1]) {
                nums[i] *= 2;
                nums[i + 1] = 0;
            }
        }
        
        var index = 0;
        
        for (var i = 0; i < nums.Length; i++) {
            if (nums[i] != 0) {
                nums[index] = nums[i];
                index++;
            }
        }

        for (var i = index; i < nums.Length; i++) {
            nums[i] = 0;
        }

        return nums;
    }
}