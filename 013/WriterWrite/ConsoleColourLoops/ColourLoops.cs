using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleColourLoops
{
    public static class ColourLoops
    {
        public static void LoopForeground(string chars, int length)
        {
            Random rand = new Random();
            for ( int i = 0; i < length; i++ )
            {
                int x = rand.Next(0, 16);
                switch ( x )
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(chars);
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(chars);
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(chars);
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write(chars);
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write(chars);
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(chars);
                        break;
                    case 6:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write(chars);
                        break;
                    case 7:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.Write(chars);
                        break;
                    case 8:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write(chars);
                        break;
                    case 9:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write(chars);
                        break;
                    case 10:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write(chars);
                        break;
                    case 11:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(chars);
                        break;
                    case 12:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write(chars);
                        break;
                    case 14:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(chars);
                        break;
                    case 15:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(chars);
                        break;
                    case 16:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(chars);
                        break;
                }
            }
            Console.WriteLine();
        }

        public static void LoopBackground(string chars, int length)
        {
            Random rand = new Random();
            for ( int i = 0; i < length; i++ )
            {
                int x = rand.Next(0, 16);
                switch ( x )
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.Write(chars);
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write(chars);
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write(chars);
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.Write(chars);
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write(chars);
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.Write(chars);
                        break;
                    case 6:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.Write(chars);
                        break;
                    case 7:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.Write(chars);
                        break;
                    case 8:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.Write(chars);
                        break;
                    case 9:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.Write(chars);
                        break;
                    case 10:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.Write(chars);
                        break;
                    case 11:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        Console.Write(chars);
                        break;
                    case 12:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.Write(chars);
                        break;
                    case 14:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.Write(chars);
                        break;
                    case 15:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write(chars);
                        break;
                    case 16:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(chars);
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}
