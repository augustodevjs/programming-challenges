namespace programming_challenges.Arrays.two_pointers;

public class MoveZeroes
{
    // https://leetcode.com/problems/move-zeroes/
    public void MoveZeroes(int[] nums) {
        int nextNonNumber = 0;

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] != 0) {
                (nums[i], nums[nextNonNumber]) = (nums[nextNonNumber], nums[i]);
                nextNonNumber++;
            }
        }
    }
}