//Write a program to Replace lower case characters to upper case and Vice - versa.

using System;
class CharacterConvertion
{
    public static void Main(String[] args)
    {
        string s = "Hello World";
        string res = "";
        foreach (char c in s)
        {
            if (Char.IsUpper(c))
            {
                res += c.ToString().ToLower();
            }
            else
            {
                res += c.ToString().ToUpper();
            }
        }
        Console.WriteLine("Output = " + res);
    }
}
