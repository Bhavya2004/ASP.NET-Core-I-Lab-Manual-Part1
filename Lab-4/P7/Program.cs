// Write program showing use of common methods of String class

using System;

public class StringMethods
{
    public static void Main()
    {
        string text = "Hello, World!";

        // Length
        int length = text.Length;
        Console.WriteLine("Length of the string: " + length);

        // Substring
        string s = text.Substring(7);
        Console.WriteLine("Substring starting from index 7: " + s);

        // IndexOf
        int i = text.IndexOf("World");
        Console.WriteLine("Index of 'World': " + i);

        // Replace
        string r = text.Replace("Hello", "Hi");
        Console.WriteLine("Text after replacement: " + r);

        // ToUpper and ToLower
        string up = text.ToUpper();
        string lc = text.ToLower();
        Console.WriteLine("Uppercase: " + up);
        Console.WriteLine("Lowercase: " + lc);

        // Split
        string sen = "This is a sample sentence.";
        string[] words = sen.Split(' ');
        Console.WriteLine("Words in the sentence:");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        // Trim
        string Text = "   Some text with spaces   ";
        string trimmedText = Text.Trim();
        Console.WriteLine("Trimmed text: " + trimmedText);
    }
}
