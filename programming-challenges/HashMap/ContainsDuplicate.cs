namespace programming_challenges.HashMap;

public class ContainsDuplicate
{
    // https://leetcode.com/problems/contains-duplicate/
    public bool ContainsDuplicateSolution(int[] nums) {
        return new HashSet<int>(nums).Count != nums.Length ? true : false;
    }
}