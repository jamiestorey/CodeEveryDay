using System;

class Program
{
    static void Main(string[] args)
    {
        Console.SetBufferSize(999 + 5, 999 + 5);
        Random random = new Random();
        int xx = 0;
        int y = 0;
        for (int i = 0; i < 999; i++)
        {
            int x = random.Next(0, 16);
            switch (x)
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Yellow;

                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.White;

                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.BackgroundColor = ConsoleColor.Red;

                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.BackgroundColor = ConsoleColor.Magenta;

                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.BackgroundColor = ConsoleColor.Green;

                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.BackgroundColor = ConsoleColor.Gray;

                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.DarkYellow;

                    break;
                case 7:
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.BackgroundColor = ConsoleColor.DarkRed;

                    break;
                case 8:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;

                    break;
                case 9:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;

                    break;
                case 10:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.BackgroundColor = ConsoleColor.DarkGray;

                    break;
                case 11:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.BackgroundColor = ConsoleColor.DarkCyan;

                    break;
                case 12:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.BackgroundColor = ConsoleColor.DarkBlue;

                    break;
                case 14:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.Cyan;

                    break;
                case 15:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Blue;

                    break;
                case 16:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.BackgroundColor = ConsoleColor.Black;

                    break;
            }
            xx++;
            y++;
            if (xx >= 16)
            {
                xx = 0;

            }

            Console.SetCursorPosition(xx, i);
            Console.Write("[{0}]", i);

        }
        Console.ReadLine();
    }
}