// Write a program to change the case of entered character.
using System;
using System.IO;

public class CharCaseChange
{
    public static void Main()
    {
        Console.Write("Enter a character: ");
      //  The Console.ReadKey().KeyChar method is used to directly read a single character from the console input.
        char character = Console.ReadKey().KeyChar;

        char changedCharacter = char.IsLower(character) ? char.ToUpper(character) : char.ToLower(character);
        Console.WriteLine("\nChanged character: " + changedCharacter);
    }
}
