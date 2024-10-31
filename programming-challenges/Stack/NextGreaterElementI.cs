namespace programming_challenges.Stack;

public class NextGreaterElementI
{
    // https://leetcode.com/problems/next-greater-element-i/  
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        Dictionary<int, int> nextGreater = new Dictionary<int, int>();
        Stack<int> stack = new Stack<int>();
        
        foreach (var num in nums2) {
            while (stack.Count > 0 && stack.Peek() < num) {
                nextGreater[stack.Pop()] = num;
            }
            stack.Push(num);
        }
        
        while (stack.Count > 0) {
            nextGreater[stack.Pop()] = -1;
        }
        
        int[] result = new int[nums1.Length];
        for (int i = 0; i < nums1.Length; i++) {
            result[i] = nextGreater[nums1[i]];
        }
        
        return result;
    }
}