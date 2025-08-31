using System;
using System.Collections.Generic;


namespace Practice;

public class Exercise
{
    public static void Main(string[] args)
    {
        DoCharsInCommon();

    }

    public static void DoCharsInCommon()
    {
        Console.WriteLine("Give us a first string.");
        string str1=Console.ReadLine() ?? "";

        Console.WriteLine("Give us a second string.");
        string str2=Console.ReadLine() ?? "";

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


 





}
