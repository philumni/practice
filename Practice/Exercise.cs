using System;
using System.Collections.Generic;


namespace Practice;

public class Exercise
{
    public static void Main(string[] args)
    {
        DoCharsInCommon();
        DoFizzBuzz();
        DoPalindrome();
    }

    public static void DoPalindrome()
    {
        Console.WriteLine("Enter a string to check if it's a palindrome:");
        string input = Console.ReadLine() ?? "";
        bool result = isPalindrome(input);
        Console.WriteLine(result ? "It is a palindrome." : "It is not a palindrome.");
        Console.ReadLine();
    }

    public static void DoCharsInCommon()
    {
        Console.WriteLine("Give us a first string.");
        string str1 = Console.ReadLine() ?? "";

        Console.WriteLine("Give us a second string.");
        string str2 = Console.ReadLine() ?? "";

        Console.WriteLine("The characters in common are: ");
        Console.WriteLine(CharsInCommon(str1, str2));
        Console.ReadLine();
    }


    public static string CharsInCommon(string str1, string str2)
    {
        HashSet<char> charsInCommon = new HashSet<char>();
        HashSet<char> secondString = new HashSet<char>();

        if (str1.Length == 0 || str2.Length == 0) throw new ArgumentException("String(s) cannot be empty");

        foreach (char c in str2.ToCharArray())
        {
            secondString.Add(c);
        }

        foreach (char c in str1.ToCharArray())
        {
            if (secondString.Contains(c))
            {
                charsInCommon.Add(c);
            }
        }

        return new String(charsInCommon.ToArray());
    }

    public static void DoFizzBuzz()
    {
        Console.WriteLine("Give us a number for FizzBuzz inclusive.");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(DoFizzBuzzString(DoFizzBuzzMain(n)));
        Console.ReadLine();
    }

    public static string DoFizzBuzzString(string[] result)
    {
        int j = 0;

        String output = "";
        for (; j < result.Length - 1; j++)
        {
            output += result[j] += ", ";
        }
        output += result[j];
        return output;
    }

    private static string[] DoFizzBuzzMain(int n)
    {
        // accomodate zero with n + 1 , FizzBuzz(300) should show you "300."
        string[] result = new string[n + 1];

        for (int j = 0; j <= n; j++)
        {
            string key = "";
            if (j % 3 == 0 && j % 5 == 0) key = "FizzBuzz";
            else if (j % 3 == 0) key = "Fizz";
            else if (j % 5 == 0) key = "Buzz";
            else key = "" + j;
            result[j] = key;
        }
        return result;
    }

    public static bool isPalindrome(string str)
    {
        return innerPalindrome(0, str.Length - 1, str);
    }

    private static bool innerPalindrome(int leftIndex, int rightIndex, string s)
    {
        if (s[leftIndex] != s[rightIndex]) return false;

        // covers odd case, even case, and empty string
        if (leftIndex >= rightIndex) return true;

        leftIndex++;
        rightIndex--;
        return innerPalindrome(leftIndex, rightIndex, s);
    }

}
