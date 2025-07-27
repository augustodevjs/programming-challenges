namespace programming_challenges.HashMap;

public class SingleNumber
{
    // https://leetcode.com/problems/single-number/
    public int SingleNumberSolution(int[] nums) {
        // Create a dictionary to count occurrences of each number
        Dictionary<int, int> dict = new Dictionary<int, int>();

        // Iterate through the array and populate the dictionary
        foreach(var num in nums) {
            // If the number is not in the dictionary, add it with a count of 1
            if (!dict.ContainsKey(num)) 
                dict[num] = 1;
            else
                // If the number is already in the dictionary, increment its count
                dict[num] += 1;
        }

        // Iterate through the dictionary to find the number that appears only once
        foreach (var key in dict.Keys) {
            // If the count of the number is 1, return that number
            if (dict.TryGetValue(key, out var value) && value == 1) {
                return key;
            }
        }
        
        // If no single number is found, return 0 (or throw an exception based on requirements)
        // This is a fallback; ideally, the input guarantees a single number exists.
        return 0;
    }
}