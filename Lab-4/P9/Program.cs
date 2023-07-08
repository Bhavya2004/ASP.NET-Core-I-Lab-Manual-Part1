// Write a program to find the longest word in a string

using System;

public class LongestWord
{
    public static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string[] words = input.Split(' ');

        string longestWord = "";

        foreach (string word in words)
        {
            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }
        }

        Console.WriteLine("The longest word is: " + longestWord);
    }
}
