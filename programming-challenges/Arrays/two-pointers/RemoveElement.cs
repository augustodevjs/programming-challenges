namespace programming_challenges.Arrays.two_pointers;

public class RemoveElement
{
    // https://leetcode.com/problems/remove-element/
    public int RemoveElementSolution(int[] nums, int val) {
        int current = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[current] = nums[i];
                current++;
            }
        }

        return current;
    }
}