namespace programming_challenges;

public class Program
{
    public static void Main()
    {
        int[] array = { 2, 3, 5, 7, 9, 11, 13, 17, 19, 23 };
        
        var target = 11;

        var index = BinarySearch(array, target);

        Console.WriteLine(index); // Output: 5
    }

    public static int BinarySearch(int[] array, int target)
    {
        var left = 0;
        var right = array.Length - 1;

        while (left <= right)
        {
            var mid = left + (right - left) / 2;

            if (array[mid] == target)
                return mid;

            if (array[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1;
    }
}

