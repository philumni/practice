using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;


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
        if (input.Length == 0) doExit();

        bool result = isPalindrome(input);
        Console.WriteLine(result ? "It is a palindrome." : "It is not a palindrome.");
        Console.ReadLine();
    }

    public static void DoCharsInCommon()
    {
        Console.WriteLine("Give us a first string.");
        string str1 = Console.ReadLine() ?? "";
        if (str1.Length == 0) doExit();

        Console.WriteLine("Give us a second string.");
        string str2 = Console.ReadLine() ?? "";
        if (str2.Length == 0) doExit();

        Console.WriteLine("The unique characters in common are: ");
        Console.WriteLine(CharsInCommon(str1, str2));
        Console.ReadLine();
    }
    
    public static void DoFizzBuzz()
    {
        Console.WriteLine("Give us a number (0 to 3000) for FizzBuzz inclusive.");
 
        String num = Console.ReadLine() ?? "";

        int n = 0;
        if (num.Length == 0 || !Int32.TryParse(num, out n)) doExit();
       
        if (n < 0 || n > 3000) doExit();
        
        Console.WriteLine(DoFizzBuzzString(DoFizzBuzzMain(n)));
        Console.ReadLine();
    }


    public static string CharsInCommon(string str1, string str2)
    {
        if (str1 == null || str2 == null) throw new ArgumentException("String(s) cannot be null");
        if (str1.Length == 0 || str2.Length == 0) throw new ArgumentException("String(s) cannot be empty");

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
        if (n < 0 || n > 3000) throw new ArgumentException("Number must be between 0 and 3000 inclusive.");

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
        if (s == null) throw new ArgumentException("String cannot be null");
        if (s.Length == 0) throw new ArgumentException("String cannot be empty");

        if (s[leftIndex] != s[rightIndex]) return false;

        // covers odd string lenghth case, and even case.
        if (leftIndex >= rightIndex) return true;

        leftIndex++;
        rightIndex--;
        return innerPalindrome(leftIndex, rightIndex, s);
    }

    private static void doExit()
    {
        Console.WriteLine("Exiting due to invalid input. Regards.");
        Console.WriteLine("Press Enter to exit.");
        Console.ReadLine();
        Environment.Exit(0);
    }

}
