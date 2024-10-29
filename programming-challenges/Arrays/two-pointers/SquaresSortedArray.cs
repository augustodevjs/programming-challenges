namespace programming_challenges.Arrays.two_pointers;

public class SquaresSortedArray
{
    // https://leetcode.com/problems/squares-of-a-sorted-array/
    public int[] SortedSquares(int[] nums) {
        var numsLength = nums.Length;
        var sortedSquareArray = new int[numsLength];

        var left = 0;
        var rigth = numsLength - 1;
        var index = numsLength - 1;

        while (left <= rigth) {
            var leftSquare = nums[left] * nums[left]; 
            var rigthSquare = nums[rigth] * nums[rigth];

            if (leftSquare >= rigthSquare) 
            {
                sortedSquareArray[index] = leftSquare;
                left++;
            }
            else
            {
                sortedSquareArray[index] = rigthSquare;
                rigth--;
            }

            index--;
        }

        return sortedSquareArray;
    }
}