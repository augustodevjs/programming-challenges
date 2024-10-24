namespace programming_challenges.Arrays.two_pointers;

public class TwoSum2
{
    // https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
    public int[] TwoSum(int[] numbers, int target) {
        var indices = new int[2];

        var left = 0;
        var right = numbers.Length - 1;

        while (left < right) {
            int sum = numbers[left] + numbers[right];

            if (sum == target) {
                indices[0] = left + 1;
                indices[1] = right + 1;
                break;
            }

            if (sum < target) {
                left++;
            }
            else {
                right--;
            }
        }

        return indices;
    }
}