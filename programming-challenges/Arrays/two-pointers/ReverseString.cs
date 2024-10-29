namespace programming_challenges.Arrays.two_pointers;

public class ReverseString
{
    // https://leetcode.com/problems/reverse-string/
    public void ReverseStringSolution(char[] s) {
        int left = 0;
        int rigth = s.Length - 1;

        while (left < rigth) {
            (s[left], s[rigth]) = (s[rigth], s[left]);

            rigth--;
            left++;
        }
    }
}