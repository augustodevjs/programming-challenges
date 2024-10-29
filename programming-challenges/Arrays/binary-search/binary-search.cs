namespace programming_challenges.Arrays.binary_search;

public class binary_search
{
    // https://leetcode.com/problems/binary-search/
    public int Search(int[] nums, int target) {
        var left = 0;
        var right = nums.Length - 1;

        while (left <= right) {
            var mid = left + (right - left) / 2;

            if (nums[mid] == target) {
                return mid;
            }

            if (nums[mid] > target) 
                right = mid - 1;
            else
                left = mid + 1;
        }

        return -1;
    }
}