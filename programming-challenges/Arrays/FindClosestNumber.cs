namespace programming_challenges.Arrays;

public class FindClosestNumber
{
    // https://leetcode.com/problems/find-closest-number-to-zero/
    public int FindClosestNumberSolution(int[] nums) {
        var aux = nums[0];

        foreach (var num in nums) {
            if (Math.Abs(num) < Math.Abs(aux))
                aux = num;

            if (Math.Abs(num) == Math.Abs(aux) && num > aux) {
                aux = num;
            }
        }

        return aux;
    }
}