
using ConsoleColourLoops;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WriterWrite.Forms;

namespace WriterWrite
{
    class Program
    {
        static frmTest formTest;
        static bool shouldAppExit = false;
        static string[] xx = { "a", "b" };

        static void Main(string[] args)
        {
            while ( !shouldAppExit )
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Enter a command");
                string x = Console.ReadLine();
                if ( x.Equals("open formTest") )
                {
                    formTest = new frmTest();
                    Application.Run(formTest);
                    Main(xx);
                    Console.WriteLine();
                }
                else if ( x.Equals("exit") )
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Are you sure you want to exit?");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write(" [yes],[y]\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    string response = Console.ReadLine();

                    if ( response.ToLower().Equals("yes") || response.ToLower().Equals("y") )
                    {
                        shouldAppExit = true;
                        Application.Exit();
                        return;
                    }
                    else
                    {
                        Main(xx);
                    }
                }
                else if (x.Equals("cool"))
                {
                    cool();
                }
                else if (x.Equals("loop"))
                {
                    Console.WriteLine("Enter some text and hit ENTER");
                    string input = Console.ReadLine();
                    ColourLoops.LoopForeground(input, 11000);
                    
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Unkown Command\n");
                    string s = Console.ReadLine();
                    //cool();
                    //yeah();

                    //ColourLoops.LoopForeground(s, 11000);
                }
                //                Console.ReadLine();
            }
        }

        static void cool()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Woop woop = new Woop("Billy");
            Console.WriteLine(woop.name);
            woop.changeName("Douglus");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(woop.name);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(woop.changeName("Magna"));
            Console.ForegroundColor = ConsoleColor.Cyan;
            yeah();
        }

        static void yeah()
        {
            // Woop woop = new Woop("a");
            // Woop.ColourLoopBackground("[(<{}>)]", 32000);
            Woop.ColourLoopBackground("[<(:{||}:)>]", 32000);
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
