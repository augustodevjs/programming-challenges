using System.Text;

namespace programming_challenges.Stack;

public class MakeTheStringGreat
{
    // https://leetcode.com/problems/make-the-string-great/description
    public string MakeGood(string s) {
        if (s.Length == 0) {
            return "";
        }

        var stack = new Stack<char>();

        foreach (var x in s) {
            if (stack.Count > 0 && (stack.Peek() != x && char.ToLower(stack.Peek()) == char.ToLower(x))) {
                stack.Pop();
            } else {
                stack.Push(x);
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