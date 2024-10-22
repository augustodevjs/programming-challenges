namespace programming_challenges.HashMap;

public class Intersect
{
    // https://leetcode.com/problems/intersection-of-two-arrays-ii/
    public int[] IntersectSolution(int[] nums1, int[] nums2) {
        var intersection = new List<int>();
        var nums1Dictionary = new Dictionary<int, int>();

        foreach (var num1 in nums1) {
            if (nums1Dictionary.ContainsKey(num1))
                nums1Dictionary[num1] += 1;
            else
                nums1Dictionary[num1] = 1;
        }

        foreach (var num2 in nums2) {
            if (nums1Dictionary.ContainsKey(num2)) {
                if (nums1Dictionary[num2] == 0)
                {
                    continue;
                }

                nums1Dictionary[num2] -= 1;
                intersection.Add(num2);
            }
        }

        return intersection.ToArray();
    }
}