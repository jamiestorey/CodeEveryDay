using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 38; i++)
        {
            
            for (int j = 0; j < i; j++)
            {
                
                Console.Write("*");
                Console.ForegroundColor = ConsoleColor.Green;
            }

            for (int k = i + 12; k >= i; k-=3)
            {
                Console.Write("\t*");
                for (int l = k; l > k -2; l-=2)
                {
                    
                    Console.Write("[{0}]", l);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
            }
            Console.WriteLine();
            for (int m = 0; m < i - 7; m++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
        }

        Console.ReadLine();
    }
}