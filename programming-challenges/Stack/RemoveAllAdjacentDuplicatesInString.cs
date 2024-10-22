using System.Text;

namespace programming_challenges.Stack;

public class RemoveAllAdjacentDuplicatesInString
{
    // https://leetcode.com/problems/remove-all-adjacent-duplicates-in-string/
    public string RemoveDuplicates(string s) {
        Stack<char> stack = new Stack<char>();
        
        foreach (char c in s) {
            if (stack.Count > 0 && stack.Peek() == c) {
                stack.Pop();
            } else {
                stack.Push(c); 
            }
        }
        
        var sb = new StringBuilder();
        var stackArray = stack.ToArray();

        for (var i = stackArray.Length - 1; i >= 0; i--) {
            sb.Append(stackArray[i]);
        }

        return sb.ToString();
    }
}