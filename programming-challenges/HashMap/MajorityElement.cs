namespace programming_challenges.HashMap;

public class MajorityElement
{
    // https://leetcode.com/problems/majority-element/
    public int MajorityElementSolution(int[] nums)
    {
        var majorityDictionary = new Dictionary<int, int>();

        foreach (var n in nums)
        {
            if (majorityDictionary.ContainsKey(n))
                majorityDictionary[n] += 1;
            else
                majorityDictionary[n] = 1;
        }

        int majorityElement = 0; 
        int maxCount = 0; 

        foreach (var element in majorityDictionary.Keys) 
        {
            if (majorityDictionary[element] > maxCount)
            {
                maxCount = majorityDictionary[element]; 
                majorityElement = element; 
            }
        }

        return majorityElement;
    }
}