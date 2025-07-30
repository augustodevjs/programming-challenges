namespace programming_challenges.Arrays.two_pointers;

public class ContainerWithMostWater
{
    // https://leetcode.com/problems/container-with-most-water/
    public int MaxArea(int[] height) {
        // Initialize two pointers: one at the beginning, one at the end
        int left = 0;
        int right = height.Length - 1;

        // Variable to store the maximum area found so far
        int maximumContainer = 0;

        // Continue the loop until the two pointers meet
        while (left < right) {
            // Calculate the width between the two lines
            int distance = right - left;

            // Use the shorter line to calculate the height of the container
            int minHeight = Math.Min(height[left], height[right]);

            // Calculate the area using the width and the shorter height
            int area = minHeight * distance;

            // Update the maximum area if this one is larger
            if (area > maximumContainer) {
                maximumContainer = area;
            }

            if (height[left] > height[right]) {
                // If the right pointer is shorter, we move it backward.
                right--;
            } else {
                // If the left pointer is shorter, we move it forward.
                left++;
            }
        }

        // Return the maximum area found
        return maximumContainer; 
    }
}