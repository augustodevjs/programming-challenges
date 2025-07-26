namespace programming_challenges.HashMap;

public class TwoSum
{
    // https://leetcode.com/problems/two-sum/description/
    public static int[] TwoSumSolution(int[] nums, int target) {
        // Create a dictionary to store the numbers and their indices
        Dictionary<int, int> numDict = new Dictionary<int, int>();
        
        // Iterate through the array
        for (int i = 0; i < nums.Length; i++)
        {
            var complement = target - nums[i];
            
            // Check if the complement exists in the dictionary
            // If it does, return the indices of the two numbers
            if (numDict.ContainsKey(complement))
            {
                return new[] { numDict[complement], i };
            }
            
            // Add the current number and its index to the dictionary
            // Use TryAdd to avoid exceptions if the key already exists
            numDict.TryAdd(nums[i], i);
        }
        
        // If no solution is found, return an empty array
        return new int[0];
    }
}