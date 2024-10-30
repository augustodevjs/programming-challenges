﻿using System.Text;

namespace programming_challenges;

public class Program
{
    public static void Main()
    {
        var x = ReverseVowels("IceCreAm");
        Console.WriteLine(x);
    }

    static string ReverseVowels(string s) {
        var left = 0;
        var rigth = s.Length - 1;
        var str = new StringBuilder(s);

        while (left < rigth) {
            if (IsVowel(s[left]) && IsVowel(s[rigth])) {
                var temp = s[left];
                str[left] = s[rigth];
                str[rigth] = temp;
                left++;
                rigth--;
            } else {
                if (!IsVowel(s[left])) left++;
                if (!IsVowel(s[rigth])) rigth--;
            }
        }

        return str.ToString();
    }

    static bool IsVowel(char c) {
        switch (c) {
            case 'a':
            case 'A':
                return true;
            case 'e':
            case 'E':
                return true;
            case 'i':
            case 'I':
                return true;
            case 'o':
            case 'O':
                return true;
            case 'u':
            case 'U':
                return true;
            default:
                return false;
        }
    }
}

