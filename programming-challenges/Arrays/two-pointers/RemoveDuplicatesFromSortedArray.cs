namespace programming_challenges.Arrays.two_pointers;

public class RemoveDuplicatesFromSortedArray
{
    // https://leetcode.com/problems/remove-duplicates-from-sorted-array/
    public int RemoveDuplicates(int[] numbers) {
        var n = 0;

        for (var i = 1; i < numbers.Length; i++) {
            if (numbers[n] != numbers[i]) 
            {
                n++;
                numbers[n] = numbers[i];
            }
        }

        return n + 1;
    }
}