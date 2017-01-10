using System;

class Program
{
	static void Main(string[] args)
	{
		Console.BackgroundColor = ConsoleColor.DarkCyan;
		Console.WriteLine("Enter anything and hit ENTER");
		var userInput = Console.ReadLine();
		Console.BackgroundColor = ConsoleColor.Yellow;
		Console.ForegroundColor = ConsoleColor.DarkMagenta;
		Console.WriteLine("You Entered {0}", userInput);
		Console.BackgroundColor = ConsoleColor.White;
		colourLoop();
	}

	static void colourLoop()
	{
		for (int i = 0; i < 25000; i++)
		{

			string cool = intInfo(i);

			if (cool.EndsWith("0"))
			{
				Console.BackgroundColor = ConsoleColor.Black;
			}
			else if (cool.EndsWith("1"))
			{
				Console.BackgroundColor = ConsoleColor.Blue;
			}
			else if (cool.EndsWith("2"))
			{
				Console.BackgroundColor = ConsoleColor.Cyan;
			}
			else if (cool.EndsWith("3"))
			{
				Console.BackgroundColor = ConsoleColor.Gray;
			}
			else if (cool.EndsWith("4"))
			{
				Console.BackgroundColor = ConsoleColor.Green;
			}
			else if (cool.EndsWith("5"))
			{
				Console.BackgroundColor = ConsoleColor.Magenta;
			}
			else if (cool.EndsWith("6"))
			{
				Console.BackgroundColor = ConsoleColor.Red;
			}
			else if (cool.EndsWith("7"))
			{
				Console.BackgroundColor = ConsoleColor.White;
			}
			else if (cool.EndsWith("8"))
			{
				Console.BackgroundColor = ConsoleColor.Yellow;
			}
			else if (cool.EndsWith("9"))
			{
				Console.BackgroundColor = ConsoleColor.DarkGray;
			}

			Console.WriteLine(i);
			Console.WriteLine(Environment.NewLine);
			Console.WriteLine(Environment.NewLine);
		}
	}

	static string intInfo(int inty)
	{
		return inty.ToString();
	}
}
