namespace programming_challenges.Stack;

public class ValidParentheses
{
    // https://leetcode.com/problems/valid-parentheses/
    public bool IsValid(string s) {
        if (s.Length % 2 != 0) 
            return false;

        var stack = new Stack<char>();

        foreach (var c in s) {
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }
            else 
            {
                if (stack.Count == 0)
                    return false;
                
                var top = stack.Pop();

                if ((c == ')' && top != '(') || 
                    (c == '}' && top != '{') || 
                    (c == ']' && top != '['))
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}