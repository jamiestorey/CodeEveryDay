using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter anything.");
        string userInput = Console.ReadLine();
        var chars = userInput.ToCharArray();
        Console.WriteLine("The length of your string is {0} charcters.", chars.Length);
        
        for (int i = 0; i < chars.Length; i++)
        {
            Console.WriteLine("[{0}] - {1}", i + 1, chars[i]);
        }

        char[] copyOfChars = userInput.ToCharArray();
        Array.Reverse(copyOfChars);
        string reversedString = "";
        foreach (var item in copyOfChars)
        {
            reversedString += item;
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Your string reversed is {0}", reversedString);
        Console.WriteLine("Your string in UPPERCASE is {0}", userInput.ToUpper());
        Console.WriteLine("\aYour string in lowercase is {0}", userInput.ToLower());
        Console.ReadLine();
    }
}