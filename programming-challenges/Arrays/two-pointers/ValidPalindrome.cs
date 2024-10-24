namespace programming_challenges.Arrays.two_pointers;

public class ValidPalindrome
{
    // https://leetcode.com/problems/valid-palindrome/description
    public bool IsPalindrome(string s) {
        var caracteres = new List<char>();

        for (var i = 0; i < s.Length; i++) {
            if (char.IsLetterOrDigit(s[i])) {
                caracteres.Add(char.ToLower(s[i]));
            }
        }

        var left = 0;
        var right = caracteres.Count - 1;

        while (left < right) {
            if (caracteres[left] != caracteres[right]) {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}