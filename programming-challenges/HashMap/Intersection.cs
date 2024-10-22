namespace programming_challenges.HashMap;

public class Intersection
{
    // https://leetcode.com/problems/intersection-of-two-arrays/
    public int[] IntersectionSolution(int[] nums1, int[] nums2) {
        var hashNums = new HashSet<int>(nums1);
        var intersectionNums = new HashSet<int>();

        foreach(var n in nums2) {
            if (hashNums.Contains(n)) {
                intersectionNums.Add(n);
            }
        }

        return intersectionNums.ToArray();
    }
}