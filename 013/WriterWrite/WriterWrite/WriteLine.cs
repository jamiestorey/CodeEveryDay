using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriterWrite
{
    public static class WriteLine
    {
        public static string stars = "*";

        public static void writeCharLine(String chars)
        {
            Console.Write(chars);
        }

        public static void writeCharLine(String chars, byte numChars)
        {
            for ( int i = 1; i <= numChars; i++ )
            {
                Console.Write(chars);
            }
        }

        public static void writeCharLine(String chars, byte numChars, ConsoleColor foreColour)
        {
            Console.ForegroundColor = foreColour;
            for ( int i = 1; i <= numChars; i++ )
            {
                Console.Write(chars);
            }
        }

        public static void writeCharLine(String chars, byte numChars, ConsoleColor foreColour, ConsoleColor backColour)
        {
            Console.ForegroundColor = foreColour;
            Console.BackgroundColor = backColour;
            for ( int i = 1; i <= numChars; i++ )
            {
                Console.Write(chars);
            }
        }

        public static void writeCharLine(String chars, byte numChars, ConsoleColor foreColour, ConsoleColor backColour, bool newLineBefore)
        {
            Console.ForegroundColor = foreColour;
            Console.BackgroundColor = backColour;
            if ( newLineBefore == true )
            {
                Console.Write("\n");
            }
            for ( int i = 1; i <= numChars; i++ )
            {
                Console.Write(chars);
            }
        }

        public static void writeCharLine(String chars, byte numChars, ConsoleColor foreColour, ConsoleColor backColour, bool newLineBefore, bool newLineAfter)
        {
            Console.ForegroundColor = foreColour;
            Console.BackgroundColor = backColour;
            if ( newLineBefore == true )
            {
                Console.Write("\n");
            }
            for ( int i = 1; i <= numChars; i++ )
            {
                Console.Write(chars);
            }
            if ( newLineAfter == true )
            {
                Console.Write("\n");
            }
        }

        public static void writeCharLine(byte numLines, String chars = "*", byte numChars = 15, ConsoleColor foreColour = ConsoleColor.Black, ConsoleColor backColour = ConsoleColor.Yellow, bool newLineBefore = false, bool newLineAfter = true)
        {
            Console.ForegroundColor = foreColour;
            Console.BackgroundColor = backColour;
            if ( newLineBefore == true )
            {
                Console.Write("\n");
            }
            for ( int i = 1; i <= numChars; i++ )
            {
                Console.Write(chars);
            }
            if ( newLineAfter == true )
            {
                Console.Write("\n");
            }
        }
    }
}
